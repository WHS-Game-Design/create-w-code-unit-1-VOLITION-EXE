using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelFront : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float turnSpeed;
    public float turnAngle = 15f;
    public float horizontalInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //turnSpeed = Mathf.Clamp(turnSpeed, turnAngle);

        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
