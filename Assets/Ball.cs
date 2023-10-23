using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Vector2 initalVelocity;

    private void Awake()
    {

        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    private void start()
    {
        GetComponent<Rigidbody2D>().velocity = initalVelocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.gameObject.name);


    }

}
