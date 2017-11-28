using UnityEngine;
using UnityEngine.Events;

namespace SellyRPG
{
    public class CharacterCharges : MonoBehaviour
    {
        [SerializeField] int currentCharges;
        [SerializeField] int maxCharges;
      
        [SerializeField] UnityEvent OnConsumeCharge;

        void Start()
        {
            currentCharges = 0;
        }

        public void IncreaseCharges()
        {
            ++currentCharges;
            Mathf.Clamp(currentCharges, 0, maxCharges);
        }

        public void ConsumeCharge()
        {
            if(currentCharges > 0)
            {
                --currentCharges;
                OnConsumeCharge.Invoke();
            }
        }
    }
}
