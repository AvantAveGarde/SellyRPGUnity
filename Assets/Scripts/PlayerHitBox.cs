using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    public GameObject fireBallBurst;
	
    //TODO:  Create unified convention for where damage is calculated on characters?
    void OnTriggerEnter2D(Collider2D item)
    {
        //TODO:  consider collsion layers instead of tags
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
