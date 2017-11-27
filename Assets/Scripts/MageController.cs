using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MageController : MonoBehaviour {

    public float moveSpeed;
    public float timeBetweenMove;
    public float timeToMove;
    private float timeBetweenMoveCounter;
    private float timeToMoveCounter;
    public float levelReloadTime;

    private bool isMoving;
    private bool reloading;

    private Vector3 moveDir;

    private Rigidbody2D myRigidBody;
    private GameObject player;
    
    void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        timeToMoveCounter = timeToMove;
        timeBetweenMoveCounter = timeBetweenMove;
	}
	
	void Update () {
        if (isMoving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDir;

            if(timeToMoveCounter < 0)
            {
                isMoving = false;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * .75f, timeBetweenMove * 1.25f);
            }
        }
        else
        {
            myRigidBody.velocity = Vector2.zero;
            timeBetweenMoveCounter -= Time.deltaTime;
            if(timeBetweenMoveCounter < 0)
            {
                isMoving = true;
                timeToMoveCounter = Random.Range(timeToMove * .75f, timeToMove * 1.25f);

                //move
                moveDir = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed);
            }
        }

        /*
        if (reloading)
        {
            levelReloadTime -= Time.deltaTime;
            if(levelReloadTime < 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                player.SetActive(true);
            }
        }
        */
	}

    
}
