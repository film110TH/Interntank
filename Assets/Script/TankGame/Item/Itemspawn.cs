using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemspawn : MonoBehaviour
{
    public MovementController movementController;
    public playerspawner spawner;


    public GameObject[] ItemspawnPoint;
    public GameObject[] Item;

    public int itemcounttospaen = 5;
    int reset;
    void Start()
    {
        spawner = FindObjectOfType<playerspawner>();
        reset = itemcounttospaen;
    }

    // Update is called once per frame
    void Update()
    {
        movementController = FindObjectOfType<MovementController>();

        if(itemcounttospaen <= 0)
        {
            ItemspawnS();
            itemcounttospaen = reset;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            ItemspawnS();
        }
    }

    void ItemspawnS()
    {
        int numofitem = Item.Length;
        int numofranditem = ItemspawnPoint.Length;
        int randpoint = Random.Range(0, numofranditem);
        int randitem = Random.Range(0, numofitem);

        GameObject item = Instantiate(Item[randitem], ItemspawnPoint[randpoint].transform.position, ItemspawnPoint[randpoint].transform.rotation);
        Destroy(item, 10f);
    }

    IEnumerator Duration()
    {
        yield return new WaitForSeconds(5f);
        movementController.speed = 1;

    }

    public void UP1()
    {
        spawner.hp += 1;
    }

    public void SpeedUP()
    {
        movementController.speed = 3;
        StartCoroutine(Duration());
    }

}
