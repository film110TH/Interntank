using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] EnemySpawnpoin;
    public GameObject[] Enemyprefab;

    public GameObject[] Enemycount;
    public GameObject EnemySpawnVFX;

    public int EnemyCount = 3;
    public int rand;
    void Start()
    {
        StartCoroutine(VFXSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        Enemycount = GameObject.FindGameObjectsWithTag("Enemy");      
    }

    IEnumerator countSpawnEnemy()
    {
        spawnEnemy();
        yield return new WaitForSeconds(1f);
        if (Enemycount.Length < EnemyCount)
        {
            StartCoroutine(VFXSpawn());
        }
        
    }

    IEnumerator VFXSpawn()
    {
        rand = Random.Range(0, 3);
        vfxspawn();
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(countSpawnEnemy());
    }

    void vfxspawn()
    {
        GameObject Vfx = Instantiate(EnemySpawnVFX, EnemySpawnpoin[rand].transform.position, EnemySpawnpoin[rand].transform.rotation);
        Destroy(Vfx, 6f);
    }


    void spawnEnemy()
    {                       
            GameObject enemy = Instantiate(Enemyprefab[0], EnemySpawnpoin[rand].transform.position, EnemySpawnpoin[rand].transform.rotation);     
    }
}
