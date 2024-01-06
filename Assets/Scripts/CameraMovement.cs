using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private const float RotationSpeed = 45.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.N))
            RotateCamera();
    }

    private void RotateCamera()
    {
        if(Input.GetAxis("Mouse X") > 0)
            transform.RotateAround(Vector3.zero, Vector3.up, RotationSpeed * Time.deltaTime);
        else if (Input.GetAxis("Mouse X") < 0)
            transform.RotateAround(Vector3.zero, Vector3.up, -RotationSpeed * Time.deltaTime);
    }
}
