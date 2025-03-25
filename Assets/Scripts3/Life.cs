using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    public float life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        if (this.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
