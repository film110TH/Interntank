using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspawner : MonoBehaviour
{
    public GameObject[] spawnpoin;
    public GameObject playerprefab;


    public int hp = 3;
    GameObject player;
    void Start()
    {
        player = Instantiate(playerprefab, spawnpoin[0].transform.position, spawnpoin[0].transform.rotation);
    }
    private void Update()
    {
    }

    public void Spawninpoin()
    {
        if(hp >0)
        player = Instantiate(playerprefab, spawnpoin[0].transform.position, spawnpoin[0].transform.rotation);
    }
}
