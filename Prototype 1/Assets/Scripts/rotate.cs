using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationSpeed;
    public float dropSpeed;
    public bool move;
    //public GameObject Balloon;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
        //Balloon = GameObject.Find("Balloon_1");
        //Balloon.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        if (move == false)
        {
            transform.position += Vector3.down * dropSpeed * Time.deltaTime;
        }
        if(transform.position.y < -15)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -0.25)
        {
            move = true;
            //Balloon.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
    {
        move = true;
    }

    }
}
