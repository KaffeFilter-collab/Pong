using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    Rigidbody2D rigidbody2D;
    public float speed;
    public float input;
    // Start is called before the first frame update
  
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Newvert");
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(0, input * speed);

    }
}
