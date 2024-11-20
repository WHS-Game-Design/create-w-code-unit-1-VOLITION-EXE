using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostEffects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public TrailRenderer boosts;
    public layerController playercotroller;

    void start() => playercotroller = FindObjectOfType<layerController>();

    void Update()
    {
        boosts= GetComponent<TrailRenderer>();

        if (playercotroller.addBoost == 1.5f){
            boosts.emitting = true;
            boosts.startColor = new Color(0f, 255f, 255f);
            boosts.endColor = new Color(0f, 255f, 255f);
        } else if (playercotroller.addBoost == 2.25f){
            boosts.emitting = true;
            boosts.startColor = new Color(1f, 0.64F, 0f);
            boosts.endColor = new Color(1f, 0.64F, 0f);
        } else if (playercotroller.addBoost == 3f){
            boosts.emitting = true;
            boosts.startColor = new Color(255f, 0f, 255f);
            boosts.endColor = new Color(255f, 0f, 255f);
        } else {
            boosts.emitting = false;
        }
    }
    
}
