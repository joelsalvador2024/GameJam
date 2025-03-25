using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerr : MonoBehaviour
{

    public GameObject Enemy;
    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        counter += Time.deltaTime;
        if(counter >= 10 ) 
        {
            Instantiate(Enemy);
            counter = 0;
        }
    }
}
