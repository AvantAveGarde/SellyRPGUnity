using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/AI/Decisions/SearchPlayer")]
    public class SearchPlayerDecision : Decision
    {
        public override bool Decide(StateManager manager)
        {
           if((manager.transform.position - manager.player.playerTransform.position).sqrMagnitude <= manager.chaseDistance * manager.chaseDistance)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
