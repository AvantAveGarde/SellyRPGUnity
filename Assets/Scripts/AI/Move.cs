using UnityEngine;

namespace SellyRPG
{
    //[CreateAssetMenu(menuName = "SellyRPG/AI/Actions/Move")]
    public class Move : Action
    {
        public override void Execute(StateManager manager)
        {
            /*if (manager.isMoving)
            {
                manager.timeToMoveCounter -= Time.deltaTime;
                manager.rb.velocity = manager.moveDir;

                if (manager.timeToMoveCounter < 0)
                {
                    manager.isMoving = false;
                    manager.timeBetweenMoveCounter = Random.Range(manager.timeBetweenMove * .75f, manager.timeBetweenMove * 1.25f);
                }
            }
            else
            {
                manager.rb.velocity = Vector2.zero;
                manager.timeBetweenMoveCounter -= Time.deltaTime;
                if (manager.timeBetweenMoveCounter < 0)
                {
                    manager.isMoving = true;
                    manager.timeToMoveCounter = Random.Range(manager.timeToMove * .75f, manager.timeToMove * 1.25f);

                    //move
                    manager.moveDir = new Vector3(Random.Range(-1f, 1f) * manager.moveSpeed, Random.Range(-1f, 1f) * manager.moveSpeed);
                }
            }*/
        }
    }
}
