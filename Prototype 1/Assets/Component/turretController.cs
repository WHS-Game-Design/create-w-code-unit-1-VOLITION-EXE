using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    static public float xrotate;
    public float sensitivity = 5f;
    public Vector3 currentMouse;
    
    void Update()
    {
        xrotate = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(Vector3.up * xrotate);

        
    }
}
