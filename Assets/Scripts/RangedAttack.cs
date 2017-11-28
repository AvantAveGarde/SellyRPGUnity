using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    public int damage;
    public GameObject fireBallBurst;

    void OnTriggerEnter2D(Collider2D item)
    {
        if(item.gameObject.tag == "Enemy")
        {
            item.gameObject.GetComponent<EnemyHealthManager>().TakeDamage(damage);

            GameObject particle = Instantiate(fireBallBurst, gameObject.transform.position, gameObject.transform.rotation);

            //TODO:  object pooling
            Destroy(particle, 20);
            Destroy(gameObject);
        }
    }
}
