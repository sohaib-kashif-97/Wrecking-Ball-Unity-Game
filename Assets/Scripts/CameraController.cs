using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Reference to the Ball
    public Vector3 offset = new Vector3(0f, 10f, -10f); // Camera offset from the Ball

    void LateUpdate()
    {
        // Set camera position to follow the ball with offset
        transform.position = target.position + offset;
        // Look at the ball
        transform.LookAt(target);
    }
}
