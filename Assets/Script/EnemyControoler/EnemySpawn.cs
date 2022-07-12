using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] EnemySpawnpoin;
    public GameObject[] Enemyprefab;

    public GameObject[] Enemycount;

    public int EnemyCount = 3;
    void Start()
    {
        StartCoroutine(countSpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        //EnemyCount = FindObjectsOfType<Enemycontroller>();
    }

    IEnumerator countSpawnEnemy()
    {
        yield return new WaitForSeconds(3f);
        spawnEnemy();
    }

    void spawnEnemy()
    {      
            int rand = Random.Range(0, 3);
            GameObject enemy = Instantiate(Enemyprefab[0], EnemySpawnpoin[rand].transform.position, EnemySpawnpoin[rand].transform.rotation);     
    }
}
