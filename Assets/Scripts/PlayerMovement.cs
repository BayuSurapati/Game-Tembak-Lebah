using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float pMoveSpeed = 5f;

    public GameObject playerBullet;
    public float bulletLifetime = 1.2f;
    //public Renderer bulletRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerShoot();
    }

    public void PlayerMove()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(pMoveSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(pMoveSpeed, 0, 0) * Time.deltaTime;
        }
    }

    public void PlayerShoot()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(playerBullet, GameObject.Find("BulletFire").transform.position, Quaternion.identity);
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 1000);

            Destroy(Bullet, bulletLifetime);
        }
    }
}
