using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothspeed = 2f;
    [SerializeField] Vector3 offset = new Vector3(0, 2, -5);

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + target.TransformDirection(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        transform.LookAt(target);
    }
}
