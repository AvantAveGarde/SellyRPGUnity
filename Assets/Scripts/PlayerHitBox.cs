using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour {
    // Use this for initialization
    public GameObject fireBallBurst;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
