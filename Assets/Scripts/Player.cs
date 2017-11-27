using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float moveSpeed;
    private Vector2 input;
    private Rigidbody2D collisionBody;
    private Animator animator;

    private bool playerMoving;
    private bool playerBlocking;

    private Vector2 lastInput;
    public GameObject shields;

    // Use this for initialization
    void Start() {
        collisionBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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
            animator.SetBool("PlayerMoving", playerMoving);
            if (lastInput.y > 0)
            {
                shields.GetComponent<ShieldManager>().up_shield.SetActive(true);
            }
            else if(lastInput.y < 0)
            {
                shields.GetComponent<ShieldManager>().down_shield.SetActive(true);
            }
            else if (lastInput.x > 0)
            {
                shields.GetComponent<ShieldManager>().right_shield.SetActive(true);
            }
            else if (lastInput.x < 0)
            {
                shields.GetComponent<ShieldManager>().left_shield.SetActive(true);
            }
            playerBlocking = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            shields.GetComponent<ShieldManager>().up_shield.SetActive(false);
            shields.GetComponent<ShieldManager>().down_shield.SetActive(false);
            shields.GetComponent<ShieldManager>().left_shield.SetActive(false);
            shields.GetComponent<ShieldManager>().right_shield.SetActive(false);
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
            animator.SetFloat("MoveX", input.x);
            playerMoving = true;
            lastInput = new Vector2(input.x, 0);

        }
        else if (input.y != 0 && input.x == 0)
        {
            collisionBody.velocity = new Vector2(0, input.y);
            animator.SetFloat("MoveY", input.y);
            playerMoving = true;
            lastInput = new Vector2(0, input.y);
        }

        if(playerMoving == false)
        {
            collisionBody.velocity = new Vector2(0, 0);
            animator.SetFloat("MoveY", 0);
            animator.SetFloat("MoveX", 0);
        }

        animator.SetBool("PlayerMoving", playerMoving);
        animator.SetFloat("LastMoveX", lastInput.x);
        animator.SetFloat("LastMoveY", lastInput.y);
    }
}
