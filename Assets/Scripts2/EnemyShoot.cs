using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private Animator enemyAnimator;
    public GameObject bullet;
    float counter;

    private SoundManager soundManager;

    private void Awake()
    {
        soundManager = FindAnyObjectByType<SoundManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 1)
        {
            Shoot();
            counter = 0;
        }

    }

    void Shoot()
    {
        enemyAnimator.Play("EnemyAttack", 0, 0.25f);
        GameObject IBullet = Instantiate(bullet, this.gameObject.transform.position, this.gameObject.transform.rotation);
        IBullet.GetComponent<BulletBehaviour>().parentEnemy = this.gameObject;
        soundManager.SeleccionAudio(1, 0.5f);
    }
}
