using UnityEngine;

namespace SellyRPG
{
    public abstract class Decision : ScriptableObject
    {
        public abstract bool Decide(StateManager manager);
    }
}
