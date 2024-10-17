using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    /*private float speed = 20f;
    private float turnSpeed = 50f;
    private float horizontalInput;
    private float verticalInput; */

    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    public float drag;
    public float limiter;
    public Vector3 move;
    public float boostPower;
    public float speedBoost;
    public float addBoost;

    public float _addBoost
    {get{return addBoost;}}
    
    public float endTime; 
    public float startTime;

    void Update()
    {
        horizontalInput = -1 * Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (addBoost == boostPower){
        speedBoost += Mathf.Abs(horizontalInput * Time.deltaTime * verticalInput);
        }
        if (horizontalInput == 0 && verticalInput != 0 && speedBoost > 3 && speedBoost <= 8) {
            addBoost = boostPower * 1.5f;
        } else if (horizontalInput == 0 && verticalInput != 0 && speedBoost > 8 && speedBoost <= 13) {
            addBoost = boostPower * 2f;
        } else if (horizontalInput == 0 && verticalInput != 0 && speedBoost > 13) {
            addBoost = boostPower * 2.5f;
        } 
        if (horizontalInput == 0){
            speedBoost = 0;
        }
        if (addBoost != boostPower)
        {
            endTime -= Time.deltaTime;
        }
        if (endTime < 0){
            addBoost = 1;
            endTime = startTime;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        move += speed * verticalInput *addBoost* Time.deltaTime * Vector3.forward;

        move = Quaternion.Euler(0, horizontalInput * turnSpeed * -1 * Time.deltaTime, 0) * move;

        transform.Translate(move * Time.deltaTime);

        //if(verticalInput == 0)
        //move = Vector3.Lerp(move, Vector3.zero, drag * Time.deltaTime);

        move *= drag;



        move = Vector3.ClampMagnitude(move, limiter * addBoost);
        
        transform.Rotate(horizontalInput * Time.deltaTime * turnSpeed * verticalInput * Vector3.up);


        /*transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);

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
