using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Transform shootingPoin;
    public float[] Dir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Dir = new float[4] { 0, 90, 180, 270 };
        StartCoroutine(ChangeCount());
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = shootingPoin.up * speed;

    }
       

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CanDestroy") || collision.gameObject.CompareTag("CantDestroy"))
        {
            this.transform.eulerAngles = new Vector3(0f, 0f, Dir[Random.Range(0, 4)]);
        }
    }

    IEnumerator ChangeCount()
    {
        yield return new WaitForSeconds(5f);
        changemove();
        StartCoroutine(ChangeCount());
    }

    void changemove()
    {
        this.transform.eulerAngles = new Vector3(0f, 0f, Dir[Random.Range(0, 4)]);
    }
}
