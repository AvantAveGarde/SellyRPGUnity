using UnityEngine;

public class PlayerUIManager : MonoBehaviour
{
    public int playerMaxHP;
    public int playerMaxCharges;

    public int playerHP;
    public int playerCharges;
	void Start () {
        playerHP = playerMaxHP;
        playerCharges = 0;
	}
	
	void Update ()
    {
		if(playerHP < 0)
        {
            gameObject.SetActive(false);

            //gamemanager.respawn or something
        }
	}

    public void TakeDamage(int damage)
    {
        playerHP -= damage;
    }

    public void SetMaxHealth()
    {
        playerHP = playerMaxHP;
    }

    public void IncreaseCharges()
    {
        playerCharges += 1;
        Mathf.Clamp(playerCharges, 0, playerMaxCharges);
    }
}
