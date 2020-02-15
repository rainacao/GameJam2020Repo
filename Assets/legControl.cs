using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legControl : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("e"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(force, ForceMode2D.Impulse);
        }
        else if (Input.GetKey("q"))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(-force, ForceMode2D.Impulse);
        }
        else
        {
            rigid.freezeRotation = true;
        }
    }
}
