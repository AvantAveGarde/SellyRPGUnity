using UnityEngine;

namespace SellyRPG
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Execute(StateManager manager);
    }
}
