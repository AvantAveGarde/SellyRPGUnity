using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/AI/Actions/Patrol")]
    public class Patrol : Action
    {
        public override void Execute(StateManager manager)
        {
            //TODO:  fix to use Character class
            //manager.character.Move(manager.waypoints[manager.waypointIndex].position);
            manager.character.SetDestination(manager.waypoints[manager.waypointIndex].position);

            if ((manager.transform.position - manager.waypoints[manager.waypointIndex].position).sqrMagnitude <= manager.character.stoppingDistance * manager.character.stoppingDistance)
            {
                manager.waypointIndex = (manager.waypointIndex + 1) % manager.waypoints.Length;
            }
        }
    }
}
