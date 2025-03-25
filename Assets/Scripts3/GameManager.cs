using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Life>().life <= 0)
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        Time.timeScale = 0;
        deathScreen.SetActive(true);
    }

}
