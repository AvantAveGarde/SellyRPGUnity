using UnityEngine;

namespace SellyRPG
{
    public class CharacterCharges : MonoBehaviour
    {
        [SerializeField] int currentCharges;
        [SerializeField] int maxCharges;
        // Use this for initialization
        void Start()
        {
            currentCharges = 0;
        }

        public void IncreaseCharges()
        {
            ++currentCharges;
            Mathf.Clamp(currentCharges, 0, maxCharges);
        }
    }
}
