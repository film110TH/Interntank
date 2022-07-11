using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int speed;
    public Rigidbody2D rb;

    public float MoveHorizontal;
    public float MoveVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        MoveHorizontal = Input.GetAxis("Horizontal");
        MoveVertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(MoveHorizontal, MoveVertical, 0f);

        //transform.Translate(new Vector3(MoveHorizontal, MoveVertical, 0f) * Time.deltaTime);


        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.velocity = new Vector2(rb.velocity.x*speed, rb.velocity.y);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += new Vector3(-1f, 0f, 0f) * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0f, -1f, 0f) * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += new Vector3(1f, 0f, 0f) * speed * Time.deltaTime;
        //}
    }

    
}
