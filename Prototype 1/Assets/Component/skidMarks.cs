using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skidMarks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public TrailRenderer kidMarks;
    public float horizontalInput;
    void Update()
    {
        kidMarks = GetComponent<TrailRenderer>();
        horizontalInput = -1 * Input.GetAxis("Horizontal");
        if (horizontalInput >= 0.5 || horizontalInput <= -0.5){
            kidMarks.emitting = true;
        } else {
            kidMarks.emitting = false;
        }
    }
}
