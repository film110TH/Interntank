using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject pratical;
    Transform poin;
    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        poin = this.transform;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("CanDestroy")|| collision.gameObject.CompareTag("CantDestroy"))
        {
            GameObject pa =  Instantiate(pratical,poin.position,poin.rotation);
            Destroy(pa,3f);
            Destroy(this.gameObject);
        }    

        if(this.gameObject.name == "Pbullet(Clone)" && collision.gameObject.CompareTag("Enemy")
            || (this.gameObject.name == "Ebullet(Clone)" && collision.gameObject.CompareTag("Player")))
        {
            GameObject pa = Instantiate(pratical, poin.position, poin.rotation);
            Destroy(pa, 3f);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        //if (this.gameObject.name == "Ebullet(Clone)" && collision.gameObject.CompareTag("Player"))
        //{
        //    GameObject pa = Instantiate(pratical, poin.position, poin.rotation);
        //    Destroy(pa, 3f);
        //    Destroy(this.gameObject);
        //    Destroy (collision.gameObject);
        //}
    }
}
