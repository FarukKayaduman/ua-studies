using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        transform.localEulerAngles += new Vector3(0, rotationSpeed * Time.deltaTime * 20.0f, 0);
    }
}
