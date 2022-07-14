using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] EnemySpawnpoin;
    public GameObject[] Enemyprefab;

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
    }

    IEnumerator countSpawnEnemy()
    {
        spawnEnemy();
        yield return new WaitForSeconds(1f);

        if(EnemyCount-1 > 0)
        {
            StartCoroutine(VFXSpawn());
            EnemyCount--;
        }
        
           
    }

    IEnumerator VFXSpawn()
    {
        int Allspawnpoint =  EnemySpawnpoin.Length;
        Debug.Log(Allspawnpoint);
        rand = Random.Range(0, Allspawnpoint);
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
            int ra = Random.Range(0, 4);
            GameObject enemy = Instantiate(Enemyprefab[ra], EnemySpawnpoin[rand].transform.position, EnemySpawnpoin[rand].transform.rotation);     
    }
}
