using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/AI/Actions/Fire")]
    public class Fire : Action
    {
        public override void Execute(StateManager manager)
        {
            manager.fireTimer += Time.deltaTime;
            if(manager.fireTimer >= manager.fireRate)
            {
                manager.FireProjectile();
                manager.fireTimer = 0;
            }
        }
    }
}
