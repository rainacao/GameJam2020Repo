using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftLowerArm : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float force = 0;
    private Collider2D myColl;
    public Collider2D[] list = { };
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = true;
        myColl = GetComponent<Collider2D>();
        foreach(Collider2D coll in list)
        {
            Physics2D.IgnoreCollision(myColl, coll);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("2"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(force, ForceMode2D.Force);
        }
        else if (Input.GetKey("w"))
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
