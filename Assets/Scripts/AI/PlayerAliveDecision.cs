using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/AI/Decisions/PlayerAlive")]
    public class PlayerAliveDecision : Decision
    {
        public override bool Decide(StateManager manager)
        {
            bool playerIsAlive = manager.player.playerTransform.gameObject.activeSelf;
            return playerIsAlive;
        }
    }
}
