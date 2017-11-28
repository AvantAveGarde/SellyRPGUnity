using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    // Use this for initialization
    public GameObject fireBallBurst;
	
    void OnTriggerEnter2D(Collider2D item)
    {
        
        if (item.gameObject.tag == "EnemyRangedAttack")
        {
            GetComponentInParent<PlayerUIManager>().TakeDamage(10);

           
            GameObject particle = Instantiate(fireBallBurst, item.transform.position, item.transform.rotation);

            //TODO:  object pooling
            Destroy(particle, 20);
            Destroy(item.gameObject);
        }
    }
}
