using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontWheels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float turn;
    public float verticalInput;
    public float horizontalInput;
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * verticalInput * turn * Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * horizontalInput * verticalInput * turn/2 * Time.deltaTime);
    }
}
