using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testController : MonoBehaviour
{
    private Rigidbody2D rigid;
    private RelativeJoint2D rj;
    public bool moveLock = true;
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rj = GetComponent<RelativeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey("d"))
        {
            rigid.AddForce(new Vector2(force, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey("a"))
        {
            rigid.AddForce(new Vector2(-force, 0), ForceMode2D.Impulse);
        }*/
        if (Input.GetKey(KeyCode.Space) && moveLock)
        {
            rigid.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow) && moveLock)
        {
            rigid.AddTorque(-force, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && moveLock)
        {
            rigid.AddTorque(force, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(rj.enabled == true)
            {
                rj.enabled = false;
                rj.connectedBody = null;
                moveLock = true;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKey(KeyCode.UpArrow))
        {
            collision.gameObject.GetComponent<RelativeJoint2D>().connectedBody = rigid;
            collision.gameObject.GetComponent<RelativeJoint2D>().enabled = true;
            collision.gameObject.GetComponent<testController>().moveLock = false;
        }
    }
}
