using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefabbullet;
    public Transform shootpoin;

    public float speed;

    public int countBullet = 1;
    public GameObject checkbullet;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shooting();
        checkbullet = GameObject.Find("Pbullet(Clone)");
        if (checkbullet != null)
            countBullet = 0;
        else
            countBullet = 1;
    }

    void Shooting()
    {
        if(countBullet == 1)
        {
            GameObject bullet = Instantiate(prefabbullet, shootpoin.position, shootpoin.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(shootpoin.up * speed, ForceMode2D.Impulse);
        }
        
    }
}
