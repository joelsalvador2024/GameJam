using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed;
    private Animator enemyAnimator;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if(target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (target.position != transform.position)
        {
            enemyAnimator.SetBool("IsRunning", true);
        }
        if (target.position == transform.position)
        {
            enemyAnimator.SetBool("IsRunning", false);
        }

    }
}