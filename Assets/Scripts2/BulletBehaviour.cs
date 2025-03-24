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
}
