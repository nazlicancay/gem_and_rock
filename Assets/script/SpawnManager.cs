using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] gems;
    public GameObject[] rocks;
    public  float spawnx;
    void Start()
    {
        InvokeRepeating("SpawnRandomGem",2f,16);
        InvokeRepeating("SpawnRandomRock",0.5f,8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomGem()
    {
        int gemindex = Random.Range(0, gems.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnx, spawnx), 3, Random.Range(-spawnx, spawnx));
        Instantiate(gems[gemindex], spawnpos, gems[gemindex].transform.rotation);

    }
    
    void SpawnRandomRock()
    {
        int rockindex = Random.Range(0, gems.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnx, spawnx), 1, Random.Range(-spawnx, spawnx));
        Instantiate(rocks[rockindex], spawnpos, rocks[rockindex].transform.rotation);

    }
}
