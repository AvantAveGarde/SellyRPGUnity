using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D item)
    {
        if (item.gameObject.tag == "EnemyRangedAttack")
        {
            GetComponentInParent<PlayerUIManager>().IncreaseCharges();
            Destroy(item.gameObject);
        }
    }
}
