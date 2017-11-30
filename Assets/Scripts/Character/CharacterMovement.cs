using UnityEngine;

//TODO:  Test class.  Not used.
//TODO:  Unify with character script
namespace SellyRPG
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed;
        //[SerializeField] float friction;
        [SerializeField] float stoppingDistance;

        bool reachedDestination = false;

        private Rigidbody2D rb;
        private Vector2 destination;

        //private Vector2 acceleration;
        //private Vector2 velocity;
    
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            destination = rb.position;
        }

        private void FixedUpdate()
        {
            if (!reachedDestination)
            {
               
                //acceleration = direction;
                //acceleration *= moveSpeed;
                //acceleration += -friction * velocity;
                //Vector2 newPostion = (0.5f * acceleration * Time.deltaTime * Time.deltaTime) + (velocity * Time.deltaTime) + rb.position;
                //velocity = acceleration * Time.deltaTime + velocity;
                //rb.MovePosition(newPostion);

                if ((rb.position - destination).sqrMagnitude > stoppingDistance * stoppingDistance)
                {
                    Vector2 direction = (destination - rb.position).normalized;
                    //acceleration = new Vector2(0, 0);
                    rb.MovePosition(rb.position + direction * moveSpeed * Time.deltaTime);
                }
                else
                {
                    reachedDestination = true;
                }
            }
        }

        public void SetDestination(Vector2 newDestination)
        {
            destination = newDestination;
            reachedDestination = false;
        }

        public void Stop()
        {
            reachedDestination = true;
            //acceleration = new Vector2(0, 0);
        }
    }
}
