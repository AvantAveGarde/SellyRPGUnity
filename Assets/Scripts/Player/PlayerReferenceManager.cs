using UnityEngine;

namespace SellyRPG
{
    public class PlayerReferenceManager : MonoBehaviour
    {
        [SerializeField] PlayerReference playerReference;
       
        void OnEnable()
        {
            playerReference.playerUI = GetComponent<PlayerUIManager>();
            playerReference.playerTransform = transform;
        }

        
        void OnDisable()
        {
            playerReference.playerUI = null;
            playerReference.playerTransform = null;
        }
    }
}
