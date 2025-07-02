using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            GameObject.Find("Manager").GetComponent<Manager>().score += 1;
            //GameObject.Find("Manager").GetComponent<Manager>().SaveScore();
            GameObject.Find("EnemyHurt").GetComponent<AudioSource>().Play();

            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
