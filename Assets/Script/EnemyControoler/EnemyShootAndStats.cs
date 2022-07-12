using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootAndStats : MonoBehaviour
{

    public GameObject prefabbullet;
    public Transform shootpoin;

    public float speed;

    public int hp = 1;
    void Start()
    {
         StartCoroutine(CountDowntoshoot());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator CountDowntoshoot()
    {
        yield return new WaitForSeconds(3f);
        Shooting();
        StartCoroutine(CountDowntoshoot());
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(prefabbullet, shootpoin.position, shootpoin.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootpoin.up * speed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet") && collision.gameObject.name == "Plazm")
        {
            Destroy(this.gameObject);
        }
    }
}
