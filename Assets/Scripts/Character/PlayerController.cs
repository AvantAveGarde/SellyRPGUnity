using UnityEngine;

//TODO:  Test class.  Not used.
namespace SellyRPG
{
    [RequireComponent(typeof(Character))]
    public class PlayerController : MonoBehaviour
    {

        private Character character;
        
        void Start()
        {
            character = GetComponent<Character>();
        }

        private void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            character.Move(new Vector2(x, y) * 1000);

        }
    }
}
