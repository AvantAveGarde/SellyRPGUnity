using System.Collections;
using UnityEngine;

public class RangedEnemyAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject rangedAttackProjectile;

    public float fireRate;
 
    private Vector2 bulletVelocityDir;
    private Vector2 direction;

    void Start()
    {
        StartCoroutine(FireProjectile());
    }

    IEnumerator FireProjectile()
    {
        while (true)
        {
            Vector3 current = transform.position;
            direction = player.transform.position - current;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(rangedAttackProjectile, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
           
            transform.localEulerAngles = new Vector3(0, 0, 0);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
