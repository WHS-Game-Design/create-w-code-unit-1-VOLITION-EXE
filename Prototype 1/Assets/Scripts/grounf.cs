using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounf : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed;
    void Start()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        float xRot = transform.localEulerAngles.x;
        float zRot = transform.localEulerAngles.z;
        xRot = Mathf.Clamp(xRot, 355, 5);
        zRot = Mathf.Clamp(zRot, 355, 5);
        xRot = Mathf.LerpAngle(transform.localEulerAngles.x, xRot, rotationSpeed * Time.deltaTime);
        zRot = Mathf.LerpAngle(transform.localEulerAngles.z, zRot, rotationSpeed * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(xRot, 0, zRot);
        transform.position = new(0, 0.8289671f, 0);
        
    }
}
