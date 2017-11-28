using UnityEngine;

public class PlayerHitBox : MonoBehaviour {
    // Use this for initialization
    public GameObject fireBallBurst;
	
    void OnTriggerEnter2D(Collider2D item)
    {
        
        if (item.gameObject.tag == "EnemyRangedAttack")
        {
            GetComponentInParent<PlayerUIManager>().TakeDamage(10);
            Instantiate(fireBallBurst, item.transform.position, item.transform.rotation);
            Destroy(item.gameObject);
        }
    }
}
