using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class boxcandestroy : MonoBehaviour
{
    public Tilemap candestroy;
    void Start()
    {
        candestroy = GetComponent<Tilemap>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Vector3 hitPosition = Vector3.zero;
            foreach(ContactPoint2D hit in collision.contacts)
            {
                hitPosition.x = hit.point.x  - 0.001f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.001f * hit.normal.y;
                candestroy.SetTile(candestroy.WorldToCell(hitPosition),null);
            }
                
        }
    }
   
}
