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
        if (collision.tag == "Suelo")
        {
            player.GetComponent<PlayerMovement>().isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.GetComponent<PlayerMovement>().isGrounded = false;
    }
}