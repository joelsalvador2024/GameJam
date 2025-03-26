using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Suelo" || collision.tag == "Enemy")
        {
            player.GetComponent<PlayerMovement>().jumps = 2;
        }
        if (collision.tag == "Bullet")
        {
            player.GetComponent<PlayerMovement>().isGrounded = player.GetComponent<PlayerMovement>().isGrounded;
        }
    }
}