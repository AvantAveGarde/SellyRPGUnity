using UnityEngine;

//TODO:  Test class.  Not used.
namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/Abilities/FireProjectile")]
    public class FireProjectile : Ability
    {
        [SerializeField] GameObject prebab;

        public override void Activate()
        {
            Instantiate(prebab);
        }
    }
}
