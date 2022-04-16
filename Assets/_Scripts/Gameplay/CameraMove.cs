using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float smooth = 1.0f;
    public Vector3 offset = new Vector3(0, 2, -5);
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);
    }

}
