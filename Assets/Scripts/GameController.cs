using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //public Rigidbody2D rb;
    public GameObject m_ball;
    
    //public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                hit.collider.attachedRigidbody.AddForce(Vector2.up*5, ForceMode2D.Impulse);
                //hit.collider.gameObject.transform.position = new Vector2(hit.collider.gameObject.transform.position.x , Time.deltaTime*(hit.collider.gameObject.transform.position.y + 2));

            }
        }
    }
    /*public void Left()
    {
        Debug.Log("Left");
        float moveBy = 2 * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        //transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
    }
    public void Right()
    {
        Debug.Log("Right");
        float moveBy = 2 * speed;
        rb.velocity = new Vector2(-moveBy, rb.velocity.y);
        //transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
    }*/
}
