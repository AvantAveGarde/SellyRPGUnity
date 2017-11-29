using UnityEngine;

namespace SellyRPG
{
    [CreateAssetMenu(menuName = "SellyRPG/AI/State")]
    public class State : ScriptableObject
    {
        [SerializeField] Action[] actions;
        [SerializeField] Transition[] transitions;

        public void UpdateState(StateManager manager)
        {
            PerformActions(manager);
            CheckTransitions(manager);
        }

        public void PerformActions(StateManager manager)
        {
            for (int i = 0; i < actions.Length; i++)
            {
                actions[i].Execute(manager);
            }
        }

        public void CheckTransitions(StateManager manager)
        {
            for (int i = 0; i < transitions.Length; i++)
            {
                bool succes = transitions[i].decision.Decide(manager);

                if(succes)
                {
                    manager.TransitionToState(transitions[i].trueState);
                }
                else
                {
                    manager.TransitionToState(transitions[i].falseState);
                }
            }
        }
    }
}
