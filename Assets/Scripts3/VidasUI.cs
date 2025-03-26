using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasUI : MonoBehaviour
{
    public Sprite vidas2;
    public Sprite vidas1;
    public Sprite vidas0;
    public GameObject vidas;
    // Start is called before the first frame update
    void Start()
    {
        vidas = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas.GetComponent<Life>().life == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = vidas2;
        }
        else if (vidas.GetComponent<Life>().life == 1)
        {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = vidas1;
        }
        else if (vidas.GetComponent<Life>().life == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = vidas0;
        }
    }
}
