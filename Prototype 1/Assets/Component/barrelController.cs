using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject SK_Veh_Armor_Car_Barrel_01;
    public Rigidbody Prop_Cone_01; 
    public float yrotate;
    public float Power;
    public float xRotation;

    // Update is called once per frame
    void Update()
    {
        yrotate = Input.GetAxis("Mouse Y") * -1;
        
        transform.Rotate(yrotate * Vector3.right);

        Transform objectTransform = SK_Veh_Armor_Car_Barrel_01.transform;



        if (Input.GetButton("Fire1"))
        {

            Rigidbody clone;
            clone = Instantiate(Prop_Cone_01, transform.position, transform.rotation);

            clone.velocity = transform.TransformDirection(Vector3.forward * Power);
        }
        
    }
}
