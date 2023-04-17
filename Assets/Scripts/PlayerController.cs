using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(new Vector2(0,1) * 200);
        }
    }
}
