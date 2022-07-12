using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefabbullet;
    public Transform shootpoin;

    public float speed;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shooting();
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(prefabbullet, shootpoin.position, shootpoin.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootpoin.up * speed, ForceMode2D.Impulse);
    }
}
