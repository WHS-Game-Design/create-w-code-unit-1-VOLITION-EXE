using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class turretController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float xrotate;
    public float sensitivity = 5f;
    public UnityEngine.Vector3 currentMouse;
    
    void Update()
    {
        xrotate = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(UnityEngine.Vector3.up * xrotate);
    }
}
