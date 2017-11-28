using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour {
    public int damage;
    public GameObject fireBallBurst;

    // Use this for initialization
    [HideInInspector]

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D item)
    {
        if(item.gameObject.tag == "Enemy")
        {
            item.gameObject.GetComponent<EnemyHealthManager>().TakeDamage(damage);
            Instantiate(fireBallBurst, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
