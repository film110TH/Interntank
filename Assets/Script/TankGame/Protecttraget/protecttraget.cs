using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protecttraget : MonoBehaviour
{
    public playerspawner playerspawner;
    void Start()
    {
        playerspawner = FindObjectOfType<playerspawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            playerspawner.hp =0;
            playerspawner.Spawninpoin();
            Destroy(this.gameObject);
        }
    }
}
