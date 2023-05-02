using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipesPrefab;

    float randomHeight = 0.5f;
    PlayerController playerScript;

    void Start()
    {
        InvokeRepeating("SpawnPipes", 0.5f, 2f);
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.isAlive == false)
        {
            CancelInvoke();
        }
    }
      void SpawnPipes()
    {
        Instantiate(pipesPrefab, new Vector2(10f, Random.Range(-5.0f, 1.5f)), Quaternion.identity);

    }

  
}
 