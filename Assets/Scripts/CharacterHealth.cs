using UnityEngine;
using UnityEngine.Events;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField] int currentHP;
    [SerializeField] int maxHP;

    [SerializeField] UnityEvent OnDamage;
    [SerializeField] UnityEvent OnDeath;

	void Start ()
    {
        currentHP = maxHP;
	}
	
	// Update is called once per frame
	public void Damage(int damage)
    {
        OnDamage.Invoke();

        currentHP -= damage;
		if(currentHP <= 0)
        {
            OnDeath.Invoke();
        }
	}
}
