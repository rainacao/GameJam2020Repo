using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legControl : MonoBehaviour
{
    private Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(100f, ForceMode2D.Force);
        }
        else if (Input.GetKey("a"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(-100f, ForceMode2D.Force);
        }
        else
        {
            rigid.freezeRotation = true;
        }
    }
}
