using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Transform pivotTransform;

    private void Update()
    {
        transform.RotateAround(pivotTransform.position, Vector3.up, rotationSpeed * Time.deltaTime * 20.0f);
    }
}
