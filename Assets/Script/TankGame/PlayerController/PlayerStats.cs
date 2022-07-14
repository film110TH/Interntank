using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public playerspawner playerspawner;

    void Update()
    {
        playerspawner = FindObjectOfType<playerspawner>();

        if (Input.GetKeyDown(KeyCode.L))
        {
            playerspawner.hp--;
            playerspawner.Spawninpoin();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ebullet(Clone)" && collision.gameObject.CompareTag("Bullet"))
        {
            playerspawner.hp--;
            playerspawner.Spawninpoin();
            Destroy(this.gameObject);
        }
    }


}
