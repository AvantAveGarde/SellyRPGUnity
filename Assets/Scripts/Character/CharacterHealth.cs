using UnityEngine;
using UnityEngine.Events;

//TODO:  Test class.  Not used.
//Placed on Player in the scene to demonstrate how Unity Events look like.
namespace SellyRPG
{
    public class CharacterHealth : MonoBehaviour
    {
        [SerializeField] int currentHP;
        [SerializeField] int maxHP;

        [SerializeField] UnityEvent OnDamage;
        [SerializeField] UnityEvent OnDeath;

        void Start()
        {
            currentHP = maxHP;
        }

        // Update is called once per frame
        public void Damage(int damage)
        {
            OnDamage.Invoke();

            currentHP -= damage;
            if (currentHP <= 0)
            {
                OnDeath.Invoke();
            }
        }

        public void SetHealthToMax()
        {
            currentHP = maxHP;
        }
    }
}
