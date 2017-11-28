using UnityEngine;

public class Shield : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        gameObject.SetActive(false);
    }
	
    private void OnTriggerEnter2D(Collider2D item)
    {
        //TODO:  consider collision layers instead of tags.
        if (item.gameObject.tag == "EnemyRangedAttack")
        {
            GetComponentInParent<PlayerUIManager>().IncreaseCharges();
            //TODO:  object pooling
            Destroy(item.gameObject);
        }
    }
}
