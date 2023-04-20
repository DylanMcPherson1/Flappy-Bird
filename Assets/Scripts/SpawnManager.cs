using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipesPrefab;

    float randomHeight = 0.5f;

    void Start()
    {
        InvokeRepeating("SpawnPipes", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void SpawnPipes()
    {
        Instantiate(pipesPrefab, new Vector2(10f, Random.Range(-7.1f, 3.1f)), Quaternion.identity);

    }
  
}
