using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/PlayerReference")]
    public class PlayerReference : ScriptableObject
    {
        public PlayerUIManager playerUI;
        public Transform playerTransform;
    }
}
