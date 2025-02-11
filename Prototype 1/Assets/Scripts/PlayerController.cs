using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerb;
    public float moveSpeed;
    public float verticalInput;
    private GameObject camFocal;
    public GameObject playerIndicator;
    public GameObject powerIndicators2;
    public bool punchy;
    public float punchyLength;
    public float punchyPower = 15f;
    public GameObject powerIndicators;
    // Start is called before the first frame update
    void Start()
    {
        playerb = GetComponent<Rigidbody>();
        camFocal = GameObject.Find("camFocal");
        playerIndicator = GameObject.Find("playerIndication");
        powerIndicators = GameObject.Find("punchyIndication");
        powerIndicators2 = GameObject.Find("punchyIndication(1)");
        powerIndicators.gameObject.SetActive(false);
        powerIndicators2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        playerb.AddForce(camFocal.transform.forward * moveSpeed * verticalInput * Time.deltaTime);
        playerIndicator.transform.position = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("powerUp"))
    {
        punchy = true;
        Destroy(other.gameObject);
        powerIndicators.gameObject.SetActive(true);
        powerIndicators.gameObject.SetActive(true);
        StartCoroutine(nameof(punch));
    }
    }
    private void OnCollisionEnter(Collision other)
    {
        
    if(other.gameObject.CompareTag("Enemy") && punchy)
    {
        Rigidbody enemyRb = other.gameObject.GetComponent<Rigidbody>();
        Vector3 pushBack = (other.gameObject.transform.position - transform.position).normalized;
        enemyRb.AddForce(pushBack * punchyPower, ForceMode.Impulse);
        Debug.Log("hit");
    }
    }

    IEnumerator punch()
    {
        yield return new WaitForSeconds(punchyLength/2);
        powerIndicators2.gameObject.SetActive(false);
        yield return new WaitForSeconds(punchyLength/2);
        punchy = false;
        powerIndicators.gameObject.SetActive(false);
    }
    
}
