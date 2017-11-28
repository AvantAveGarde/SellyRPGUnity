using UnityEngine;

//TODO:  Make this script usable for both players and enemies?
public class RangedAttack : MonoBehaviour
{
    public int damage;
    public GameObject fireBallBurst;

    private void Start()
    {
        Destroy(gameObject, 20);
    }

    void OnTriggerEnter2D(Collider2D item)
    {
        //TODO:  consider collsion layers instead of tags
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
