using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Itemspawn itemspawn;
    public GameObject Textpopprefab;
    public int PointstoGivePlayer;
    public string Texttoshow;

    private void Start()
    {
        itemspawn = FindObjectOfType<Itemspawn>();
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.gameObject.name == "Up1(Clone)" && collision.gameObject.CompareTag("Player"))
        {
            itemspawn.UP1();
            Destroy(this.gameObject);
            spawnText();
        }

        if(this.gameObject.name == "SpeedUp(Clone)" && collision.gameObject.CompareTag("Player"))
        {
            itemspawn.SpeedUP();
            Destroy(this.gameObject);
            spawnText();
        }
    }

    public void spawnText()
    {
        GameObject pointsText = Instantiate(Textpopprefab);
        if (pointsText.GetComponent<Textonspot>() != null)
        {
            var givePointsText = pointsText.GetComponent<Textonspot>();
            givePointsText.DisplayPoints = PointstoGivePlayer;
            givePointsText.DisplayText = Texttoshow;
        }
        pointsText.transform.position = gameObject.transform.position;
    }
}
