using UnityEngine;

//TODO:  Test class.  Not used.
//Considering using Scriptable Objects as components for attacks.
//Attacks could have a damage component, sound component, particle component, etc.

namespace SellyRPG
{
    public abstract class Ability : ScriptableObject
    {
        public abstract void Activate();
    }
}
