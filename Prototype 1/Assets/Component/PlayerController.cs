using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class layerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    public float speed;
    public float limiter;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    public Vector3 Move;
    public float drag;
    public float boostPower;
    public float speedBoost;
    public float addBoost;
    public float _addBoost
    {get{return addBoost;}}
    public float endTime; 
    public float startTime;
    void Update()
    {
        if (addBoost == boostPower){
        speedBoost += Mathf.Abs(horizontalInput * Time.deltaTime * verticalInput);
        }
        if (horizontalInput == 0 && verticalInput != 0 && speedBoost > 3 && speedBoost <= 8) {
            addBoost = boostPower * 1.5f;
        } else if (horizontalInput == 0 && verticalInput != 0 && speedBoost > 8 && speedBoost <= 13) {
            addBoost = boostPower * 2.25f;
        } else if (horizontalInput == 0 && verticalInput != 0 && speedBoost > 13) {
            addBoost = boostPower * 3f;
        } 
        if (horizontalInput == 0){
            speedBoost = 0;
        }
        if (addBoost != boostPower){
            endTime -= Time.deltaTime;
        }
        if (endTime < 0){
            addBoost = 1;
            endTime = startTime;
        }
        Move = Vector3.ClampMagnitude(Move, limiter * addBoost);

        horizontalInput = -1 * Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Move += speed * verticalInput * Time.deltaTime * addBoost * Vector3.forward;

        Move = Quaternion.Euler(0, horizontalInput * turnSpeed * Time.deltaTime, 0) * Move;

        transform.Translate(Move * Time.deltaTime);

        transform.Rotate(Vector3.up * verticalInput * Time.deltaTime * turnSpeed * horizontalInput * -1);
        



        
        if (verticalInput == 0){
        Move *= Time.deltaTime * drag;
        }
        
        // Vector3 normalizedDirection = Move.normalized;
        //Debug.DrawRay(transform.position, normalizedDirection * 10, Color.red);

        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        //Debug.DrawRay(transform.position, forward, Color.green);
        
        //don't change the pc version to this one, this is specificialy for the home computer, why? idk it's old




        //transform.Translate(Vector3.forward*Time.deltaTime* speed* verticalInput);
        //transform.Rotate(Vector3.up*Time.deltaTime* turnSpeed* horizontalInput * verticalInput);

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
