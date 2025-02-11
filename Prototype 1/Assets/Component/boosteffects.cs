using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boosteffects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public PlayerController playerController;
    public TrailRenderer boost;

    void start() => playerController = FindObjectOfType<PlayerController>();

    void Update()
    {
        boost = GetComponent<TrailRenderer>();
        if (playerController.addBoost == 1.5){
            Debug.Log("12345");
            boost.emitting = true;
        } else {
            boost.emitting = false;
        }
    }
}
