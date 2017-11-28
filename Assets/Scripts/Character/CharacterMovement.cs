using UnityEngine;

//TODO:  Test class.  Not used.
namespace SellyRPG
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField] float moveSpeed;
        // Use this for initialization

        private Rigidbody2D rb;
        //private bool isMoving;
        //private Vector2 velocity;


        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        //void Update()
        //{

        //}

        public void SetVelocity(Vector2 direction)
        {
            Vector2 velocity = direction.normalized * moveSpeed;
            rb.velocity = velocity;
        }
    }
}
