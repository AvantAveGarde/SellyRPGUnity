using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemyAttack : MonoBehaviour {
    public GameObject player;
    public GameObject rangedAttackProjectile;

    public float fireRate;
    public float bulletSpeed;
    private bool canShoot = true;
    private Vector2 bulletVelocityDir;
    private Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        
        if(canShoot)
        {
            Vector3 current = transform.position;
            direction = player.transform.position - current;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            GameObject projectile = Instantiate(rangedAttackProjectile, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));
            StartCoroutine(DestroyProjectile(projectile));
            StartCoroutine(FireProjectile());
            projectile.GetComponent<Rigidbody2D>().velocity =  transform.right * bulletSpeed;
            
            transform.localEulerAngles = new Vector3(0, 0, 0);

        }

    }

    IEnumerator FireProjectile()
    {
        canShoot = false;
        yield return new WaitForSeconds(fireRate);
        canShoot = true;
    }
    IEnumerator DestroyProjectile(GameObject projectile)
    {
        yield return new WaitForSeconds(10);
        Destroy(projectile);
    }
}
