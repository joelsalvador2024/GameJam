using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject parentEnemy;
    public float speed;
    public Vector3 direction;
    public bool canDamageEnemy = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        direction = (player.transform.position - transform.position).normalized;
        Debug.Log(direction);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.position += direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !canDamageEnemy)
        {
            collision.GetComponent<Life>().life -= 1;
            Debug.Log("AAAAAA");
            Destroy(gameObject);
        }
        if (collision.tag == "Enemy" && canDamageEnemy)
        {
            collision.GetComponent<Life>().life--;
            Destroy(gameObject);
        }
        if (collision.tag == "Suelo")
        {
            Destroy(gameObject);
        }

    }
}
