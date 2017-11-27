using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour {

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
            Destroy(item.gameObject);
        }
    }
}
