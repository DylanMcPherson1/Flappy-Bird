using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D player;
    int score = 0;
    public Text scoreUI;
    public bool isAlive;

    void Start()
    {

        player = GetComponent<Rigidbody2D>();
        isAlive = true;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            player.AddForce(new Vector2(0,1) * 400);
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
    public void OnCollisionEnter2D(Collision2D other)
    {
        isAlive = false;
    }
 
}
