using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float turnSpeed = 300f;
    public float verticalInput;
    void Update()
    {
        transform.Rotate(Vector3.right * turnSpeed * verticalInput * Time.deltaTime);
    }
}
