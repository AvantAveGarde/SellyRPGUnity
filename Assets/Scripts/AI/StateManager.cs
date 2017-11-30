using UnityEngine;

namespace SellyRPG
{
    public class StateManager : MonoBehaviour
    {
        [SerializeField] State currentState;
        [SerializeField] State remainState;

        //TODO:  Temporarily visible.  
        public GameObject player;

        //TODO:  Temprarily part of this class for testing.
        //This should be part of an enemy config or character stats class
        [SerializeField] GameObject rangedAttackProjectile;
        public float fireRate;
        [System.NonSerialized] public float fireTimer;


        public Transform[] waypoints;
        [System.NonSerialized] public int waypointIndex;
        public float chaseDistance;
        //public float moveSpeed;
        //public float timeBetweenMove;
        //public float timeToMove;
        //[System.NonSerialized] public float timeBetweenMoveCounter;
        //[System.NonSerialized] public float timeToMoveCounter;
        //[System.NonSerialized] public bool isMoving;

        //[System.NonSerialized] public float stateTimeElapsed;

        //TODO:  Temporarily part of this class for testing.
        [System.NonSerialized] public Rigidbody2D rb;
        //[System.NonSerialized] public Character character;
        [System.NonSerialized] public CharacterMovement character;
        //[System.NonSerialized] public Vector2 moveDir;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            //character = GetComponent<Character>();
            character = GetComponent<CharacterMovement>();
        }

        private void Update()
        {
            currentState.UpdateState(this);
        }

        public void TransitionToState(State newState)
        {
            if(newState != remainState)
            {
                currentState = newState;
                //OnExitState();
            }
        }

        //public bool CheckIfCountDownElapsed(float duration)
        //{
        //    stateTimeElapsed += Time.deltaTime;
        //    return (stateTimeElapsed >= duration);
        //}

        //private void OnExitState()
        //{
            //stateTimeElapsed = 0;
        //}

        //public void ResetTimer()
        //{
        //    stateTimeElapsed = 0;
        //}

        //TODO:  Temporarily part of this class for testing.
        public void FireProjectile()
        {
            Vector3 current = transform.position;
            Vector2 direction = player.transform.position - current;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(rangedAttackProjectile, transform.position, Quaternion.AngleAxis(angle, Vector3.forward));

            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}
