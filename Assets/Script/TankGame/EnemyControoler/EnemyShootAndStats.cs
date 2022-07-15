using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootAndStats : MonoBehaviour
{

    public GameObject prefabbullet;
    public Transform shootpoin;
    public Itemspawn itemspawn;

    public float speed;

    public int hp = 1;

    public GameObject Textpopprefab;
    public int PointstoGivePlayer;
    public string Texttoshow;

    public ScoreManeger ScoreManegerr;
    public AudioSource audio;

    void Start()
    {
         StartCoroutine(CountDowntoshoot());
        itemspawn = FindObjectOfType<Itemspawn>(); 
         ScoreManegerr = FindObjectOfType<ScoreManeger>();
    }

    // Update is called once per frame
    void Update()
    {
       if(hp <= 0)
       {
            spawnText();
            ScoreManegerr.Score += PointstoGivePlayer;
            ScoreManegerr.enemytikill--;
            audio.Play();
            itemspawn.itemcounttospaen--;
            Destroy(this.gameObject);
       }
    }

    IEnumerator CountDowntoshoot()
    {
        float ran = Random.Range(1, 3);
        yield return new WaitForSeconds(ran);
        Shooting();
        StartCoroutine(CountDowntoshoot());
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(prefabbullet, shootpoin.position, shootpoin.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootpoin.up * speed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet") && collision.gameObject.name == "Pbullet(Clone)"&& !collision.gameObject.CompareTag("Hitbox"))
        {
            hp--;              
        }

    }

    public void spawnText()
    {
        GameObject pointsText = Instantiate(Textpopprefab);
        if(pointsText.GetComponent<Textonspot>() != null)
        {
            var givePointsText = pointsText.GetComponent<Textonspot>();
            givePointsText.DisplayPoints = PointstoGivePlayer;
            givePointsText.DisplayText = Texttoshow;
        }
        pointsText.transform.position = gameObject.transform.position;
    }
}
