using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parry : MonoBehaviour
{
    public BoxCollider2D parryBox;

    private float timer;

    [SerializeField]
    private float parryActiveTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            parryBox.enabled = true;
        }
        
        if (parryBox.enabled)
        {
            timer += Time.deltaTime;
            if(timer >= parryActiveTime)
            {
                parryBox.enabled = false;
                timer = 0f;
            }
        }


    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("KYS");
        collision.GetComponent<BulletBehaviour>().direction = (collision.GetComponent<BulletBehaviour>().parentEnemy.transform.position - collision.gameObject.transform.position).normalized;
        collision.GetComponent<BulletBehaviour>().canDamageEnemy = true;
    }
}
