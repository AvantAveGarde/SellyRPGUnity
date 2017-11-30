using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/AI/Actions/Chase")]
    public class Chase : Action
    {
        public override void Execute(StateManager manager)
        {
            manager.character.SetDestination(manager.player.playerTransform.position);
        }
    }
}
