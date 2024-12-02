using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparksWheels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public ParticleSystem sparks;
    public float horizontalInput;
    public float speedBoost;
    public ParticleSystem.EmissionModule sparkParticle;
    void Update()
    {
        sparks = GetComponent<ParticleSystem>();
        sparkParticle = sparks.emission;
        var main = sparks.main;
        horizontalInput = -1 * Input.GetAxis("Horizontal");
        speedBoost += Mathf.Abs(horizontalInput * Time.deltaTime);
        if (horizontalInput == 0){
            speedBoost = 0;
        }
        if (speedBoost > 3 && speedBoost <= 8){
            sparkParticle.enabled = true;
            main.startColor = new Color(0, 1f, 1f, 1f);
        }else if (speedBoost > 8 && speedBoost <= 13){
            sparkParticle.enabled = true;
            main.startColor = new Color(1f, 0.64F, 0f);
        }else if (speedBoost > 13){
            sparkParticle.enabled = true;
            main.startColor = new Color(1f, 0f, 1f, 1f);
        } else if (horizontalInput == 0){
            sparkParticle.enabled = false;
        }
        
    }
}
