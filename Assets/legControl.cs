using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legControl : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float force = 0;
    private Collider2D coll;
    public Collider2D one;
    public Collider2D two;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = true;
        coll = GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(coll, one);
        Physics2D.IgnoreCollision(coll, two);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("e"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(force, ForceMode2D.Force);
        }
        else if (Input.GetKey("q"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(-force, ForceMode2D.Force);
        }
        else
        {
            rigid.freezeRotation = true;
        }
    }
}
