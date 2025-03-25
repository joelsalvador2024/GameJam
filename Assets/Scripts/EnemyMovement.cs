using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    Transform castPoint;
    
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float speed;

    Rigidbody2D rb2d;

    bool facingLeft;
    private bool isAgro = false;
    private bool isSearching;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (CanSeePlayer(agroRange))
        {
            isAgro = true;
        }
        else
        {
            if (isAgro)
            {
                if (!isSearching)
                {
                    isSearching = true;
                    Invoke("StopChasePlayer", 2);
                }
            }
        }
        if (isAgro)
        {
            ChasePlayer();
        }
    }

    bool CanSeePlayer(float distancia)
    {
        bool val = false;
        float castDist = distancia;

        if (facingLeft)
        {
            castDist = -distancia;
        }

        Vector2 endPos = castPoint.position + Vector3.right * castDist;

        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endPos, 1 << LayerMask.NameToLayer("Action"));

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                val = true;
            }
            else
            {
                val = false;
            }

            Debug.DrawLine(castPoint.position, hit.point, Color.yellow);
        }
        else
        {
            Debug.DrawLine(castPoint.position, endPos, Color.green);
        }

        return val;
    }

    //funcion para perseguir al jugador
    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            //enemigo a la izquierda del jugador, se mueve a la derecha
            rb2d.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(1, 1);
            facingLeft = false;
        }
        else
        {
            //enemigo a la derecha del jugador, se mueve a la izquierda
            rb2d.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(-1, 1);
            facingLeft = true;
        }
    }

    //funcion para dejar de perseguir al jugador
    void StopChasePlayer()
    {
        isAgro = false;
        isSearching = false;
        rb2d.velocity = new Vector2(0, 0);
    }
}