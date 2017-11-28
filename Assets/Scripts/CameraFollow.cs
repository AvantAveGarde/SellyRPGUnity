using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;
    private Vector3 targetPosition;
    public float cameraSpeed;

	void Update ()
    {
        targetPosition = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
	}
}
