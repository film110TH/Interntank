using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject pratical,hitbox;
    Transform poin;
   

    private void FixedUpdate()
    {
        poin = this.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CanDestroy") || collision.gameObject.CompareTag("CantDestroy"))
        {
            GameObject pa = Instantiate(pratical, poin.position, poin.rotation);
            Destroy(pa, 3f);
            GameObject hit = Instantiate(hitbox, poin.position, poin.rotation);
            Destroy(hit, 0.1f);
            Destroy(this.gameObject);
        }

        if (this.gameObject.name == "Pbullet(Clone)" && collision.gameObject.CompareTag("Enemy")
            || this.gameObject.name == "Ebullet(Clone)" && collision.gameObject.CompareTag("Player"))
        {
            GameObject pa = Instantiate(pratical, poin.position, poin.rotation);
            Destroy(pa, 3f);
            Destroy(this.gameObject);
            //Destroy(collision.gameObject);
        }

        if (this.gameObject.name == "Pbullet(Clone)" && collision.gameObject.name == "Ebullet(Clone)"
            || this.gameObject.name == "Pbullet(Clone)" && collision.gameObject.name == "Ebullet(Clone)")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

    }

}
