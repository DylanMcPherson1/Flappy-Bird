using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D player;
    int score = 0;
    public Text scoreUI;

    void Start()
    {

        player = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(new Vector2(0,1) * 300);
        }
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            score = score + 1;
            scoreUI.text = score.ToString();
        }
    }
 
}
