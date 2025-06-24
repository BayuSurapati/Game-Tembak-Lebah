using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            SpawnEnemies();
        }
        
    }

    public void SpawnEnemies()
    {
        Instantiate(enemy, new Vector3(Random.Range(-8,+8), 6, 0), Quaternion.identity);
    }
}
