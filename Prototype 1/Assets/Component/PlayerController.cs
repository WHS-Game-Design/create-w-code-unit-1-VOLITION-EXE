using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime* speed* verticalInput);
        transform.Rotate(Vector3.up*Time.deltaTime* turnSpeed* horizontalInput);

        /*if (Input.GetKey(KeyCode.W))
        transform.Translate(Vector3.forward*Time.deltaTime* speed);
        if (Input.GetKey(KeyCode.S))
        transform.Translate(Vector3.back*Time.deltaTime* speed);
        if (Input.GetKey(KeyCode.A))
        transform.Translate(Vector3.left*Time.deltaTime* speed);
        if (Input.GetKey(KeyCode.D))
        transform.Translate(Vector3.right*Time.deltaTime* speed); */

        /* transform.Rotate(Vector3.left*Time.deltaTime* speed);

        */
    }   
    
}
