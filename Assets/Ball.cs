using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Vector2 initalVelocity;
    public Vector3 startingposition;
    private void Awake()
    {

        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = initalVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.gameObject.name);
        rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x+ Random.Range(10,20), rigidbody2d.velocity.y+ Random.Range(20,30));



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        rigidbody2d.velocity = initalVelocity;
        transform.position = startingposition;
        rigidbody2d.velocity = new Vector2(-rigidbody2d.velocity.x, rigidbody2d.velocity.y);
    }

  
}
