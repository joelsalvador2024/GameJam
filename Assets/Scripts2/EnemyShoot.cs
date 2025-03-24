using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bullet;
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= 2)
        {
            Shoot();
            counter = 0;
        }

    }

    void Shoot()
    {
        GameObject IBullet = Instantiate(bullet, this.gameObject.transform.position, this.gameObject.transform.rotation);
        IBullet.GetComponent<BulletBehaviour>().parentEnemy = this.gameObject;
    }
}
