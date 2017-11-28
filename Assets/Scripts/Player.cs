using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float rangedAttackSpeed;

    private Vector2 input;
    private Rigidbody2D collisionBody;
    private Animator animator;
    private PlayerUIManager playerUIManager;
    private ShieldManager shieldManager;

    private bool playerMoving;
    private bool playerBlocking;

    private Vector2 lastInput;

    public GameObject shields;
    public GameObject rangedAttack;

    readonly int PLAYER_MOVING = Animator.StringToHash("PlayerMoving");
    readonly int MOVE_X = Animator.StringToHash("MoveX");
    readonly int MOVE_Y = Animator.StringToHash("MoveY");
    readonly int LAST_MOVE_X = Animator.StringToHash("LastMoveX");
    readonly int LAST_MOVE_Y = Animator.StringToHash("LastMoveY");

    // Use this for initialization
    void Start()
    {
        collisionBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerUIManager = GetComponent<PlayerUIManager>();
        shieldManager = shields.GetComponent<ShieldManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerBlocking != true){Move();}
        Block();
    }

    void Block()
    {
        playerBlocking = false;

        if (Input.GetMouseButton(1))
        {
            collisionBody.velocity = new Vector2(0, 0);
            playerMoving = false;
            animator.SetBool(PLAYER_MOVING, playerMoving);

            //Determine Which Shield to Put up
            if (lastInput.y > 0)
            {
                shieldManager.up_shield.SetActive(true);
            }
            else if(lastInput.y < 0)
            {
                shieldManager.down_shield.SetActive(true);
            }
            else if (lastInput.x > 0)
            {
                shieldManager.right_shield.SetActive(true);
                
            }
            else if (lastInput.x < 0)
            {
                shieldManager.left_shield.SetActive(true);
            }

            //Fire Projectile
            //change to use throwback method, fix collisions and create charge and firerate timer.
            if (Input.GetMouseButtonDown(0))
            {
                if(playerUIManager.playerCharges > 0)
                {
                    ThrowBack();
                    playerUIManager.playerCharges -= 1;
                }
            }
            playerBlocking = true;
        }

        //If we release the hold shield button
        if (Input.GetMouseButtonUp(1))
        {
            shieldManager.up_shield.SetActive(false);
            shieldManager.down_shield.SetActive(false);
            shieldManager.left_shield.SetActive(false);
            shieldManager.right_shield.SetActive(false);
        }
    }

    void ThrowBack()
    {
        GameObject projectile = Instantiate(rangedAttack, transform.position, transform.rotation);
        if (lastInput.x > 0)
        {
            projectile.GetComponent<Rigidbody2D>().velocity = projectile.transform.right * rangedAttackSpeed;
        }
        else if (lastInput.x < 0)
        {
            projectile.GetComponent<Rigidbody2D>().velocity = projectile.transform.right * -rangedAttackSpeed;
        }
        else if (lastInput.y > 0)
        {
            projectile.GetComponent<Rigidbody2D>().velocity = projectile.transform.up * rangedAttackSpeed;
        }
        else
        {
            projectile.GetComponent<Rigidbody2D>().velocity = projectile.transform.up * -rangedAttackSpeed;
        }
    }

    void Move()
    {
        playerMoving = false;
        
        input.x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        input.y = Input.GetAxisRaw("Vertical") * moveSpeed;
        if (input.x != 0 && input.y == 0)
        {
            collisionBody.velocity = new Vector2(input.x, 0);
            animator.SetFloat(MOVE_X, input.x);
            playerMoving = true;
            lastInput = new Vector2(input.x, 0);

        }
        else if (input.y != 0 && input.x == 0)
        {
            collisionBody.velocity = new Vector2(0, input.y);
            animator.SetFloat(MOVE_Y, input.y);
            playerMoving = true;
            lastInput = new Vector2(0, input.y);
        }

        if(playerMoving == false)
        {
            collisionBody.velocity = new Vector2(0, 0);
            animator.SetFloat(MOVE_Y, 0);
            animator.SetFloat(MOVE_X, 0);
        }

        animator.SetBool(PLAYER_MOVING, playerMoving);
        animator.SetFloat(LAST_MOVE_X, lastInput.x);
        animator.SetFloat(LAST_MOVE_Y, lastInput.y);
    }
}
