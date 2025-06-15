using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();     // NOTE: To be attached to Pinball GameObject
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from player; To be set later on!!
        float moveHorizontal = Input.GetAxis("Horizontal");     // A/D or Left/Right Arrow
        float moveVertical = Input.GetAxis("Vertical");         // W/S or Up/Down Arrow

        // Create movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Apply force to the ball
        rb.AddForce(movement * speed);
    }
}
