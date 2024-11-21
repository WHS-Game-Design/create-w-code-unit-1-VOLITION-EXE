using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 Offset = new Vector3(0, 5, -10);
    void Start()
    {
        
    }
    public float xrotate = 0f;
    public float yrotate = 0f;
    public float sensitivity = 15f;
    // Update is called once per frame
    void LateUpdate()
    {
        xrotate += Input.GetAxis("Mouse Y") * sensitivity * -1;
        yrotate += Input.GetAxis("Mouse X") * sensitivity;

        //transform.localEulerAngles = new Vector3(xrotate, yrotate, 0);
        //transform.position = player.transform.position + Offset + transform.forward;
    }
}
