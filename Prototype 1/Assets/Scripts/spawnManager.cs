using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;

    public float spawnRate;
    public float xPos;
    public float zPos;
    public Vector3 spawnPos;
    public bool findSpawn;

    void Start()
    {
        InvokeRepeating(nameof(spawnEnemy), spawnRate, spawnRate);

        random();
    }
    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Ground"))
    {
        findSpawn = false;
    }
    }
    private void OnTriggerExit(Collider other)
    {
        findSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(findSpawn == true)
        {
            random();
        }
    }
    void spawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
        random();
        findSpawn = false;

    }
    
    private Vector3 random()
    {
        xPos = Random.Range(-13f, 13f);
        zPos = Random.Range(-12f, 12f);
        spawnPos = new(xPos, 24, zPos);
        return spawnPos;
    }
    
    

}
