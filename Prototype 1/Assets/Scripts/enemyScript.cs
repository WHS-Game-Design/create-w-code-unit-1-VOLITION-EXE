using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float Speed;
    public Rigidbody enemyRB;
    private GameObject player;
    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Wrestler");
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRB.AddForce(lookDirection * Speed * Time.deltaTime);
        }
        if(transform.position.y < -15){
            Destroy(gameObject);
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
