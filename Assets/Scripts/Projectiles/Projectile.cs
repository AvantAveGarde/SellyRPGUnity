using UnityEngine;

namespace SellyRPG
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] float speed;
        [SerializeField] float lifeTime;

        private Rigidbody2D rb;
        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = transform.right * speed;

            //TODO:  object pooling
            Destroy(gameObject, lifeTime);
        }


    }
}
