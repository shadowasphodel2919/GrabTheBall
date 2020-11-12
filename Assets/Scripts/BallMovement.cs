using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Left()
    {
        Debug.Log("Left");
        float moveBy = 2 * speed;
        rb.velocity = new Vector2(-moveBy, rb.velocity.y);
        //transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
    }
    public void Right()
    {
        Debug.Log("Right");
        float moveBy = 2 * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        //transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
    }

}
