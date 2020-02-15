using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightLegControl : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        rigid.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rigid.freezeRotation = false;
            rigid.AddTorque(100f, ForceMode2D.Force);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
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
