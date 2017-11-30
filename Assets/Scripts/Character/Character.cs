using UnityEngine;

//TODO:  Test class.  Not used.
namespace SellyRPG
{
    [RequireComponent(typeof(CharacterMovement))]
    [RequireComponent(typeof(Animator))]
    public class Character : MonoBehaviour
    {
        private Animator anim;
        private CharacterMovement charMovement;

        private bool isMoving;
        private Vector2 lastInput;

        readonly int MOVING = Animator.StringToHash("PlayerMoving");
        readonly int MOVE_X = Animator.StringToHash("MoveX");
        readonly int MOVE_Y = Animator.StringToHash("MoveY");
        readonly int LAST_MOVE_X = Animator.StringToHash("LastMoveX");
        readonly int LAST_MOVE_Y = Animator.StringToHash("LastMoveY");

        void Start()
        {
            anim = GetComponent<Animator>();
            charMovement = GetComponent<CharacterMovement>();
        }

        public void Move(Vector2 input)
        {
            isMoving = false;

            if (input.x != 0 && input.y == 0)
            {
                charMovement.SetDestination(new Vector2(input.x, 0));
                anim.SetFloat(MOVE_X, input.x);
                isMoving = true;
                lastInput = new Vector2(input.x, 0);

            }
            else if (input.y != 0 && input.x == 0)
            {
                charMovement.SetDestination(new Vector2(0, input.y));
                anim.SetFloat(MOVE_Y, input.y);
                isMoving = true;
                lastInput = new Vector2(0, input.y);
            }

            if (isMoving == false)
            {
                charMovement.Stop();
                anim.SetFloat(MOVE_Y, 0);
                anim.SetFloat(MOVE_X, 0);
            }

            anim.SetBool(MOVING, isMoving);
            anim.SetFloat(LAST_MOVE_X, lastInput.x);
            anim.SetFloat(LAST_MOVE_Y, lastInput.y);
        }
    }
}
