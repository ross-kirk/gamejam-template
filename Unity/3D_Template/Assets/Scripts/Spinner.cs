using System;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f;
    [SerializeField] private RotationDirection rotationDirection = RotationDirection.Left;

    private void Update()
    {
        transform.Rotate(GetDirection(), rotationSpeed * Time.deltaTime);
    }
    
    private Vector3 GetDirection()
    {
        return rotationDirection switch
        {
            RotationDirection.Left => Vector3.left,
            RotationDirection.Right => Vector3.right,
            _ => Vector3.zero
        };
    }

    public void ReverseDirection()
    {
        rotationDirection = rotationDirection switch
        {
            RotationDirection.Left => RotationDirection.Right,
            RotationDirection.Right => RotationDirection.Left,
            _ => rotationDirection
        };
    }

    public void UpdateSpeed(float speed)
    {
        rotationSpeed = speed;
    }
}

public enum RotationDirection
{
    Left,
    Right
}