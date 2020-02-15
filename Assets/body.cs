using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
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
        if (Input.GetKey("h"))
        {
            rigid.freezeRotation = false;
            rigid.AddForce(new Vector2(30f, 0), ForceMode2D.Force);
        }
        if (Input.GetKey("f"))
        {
            rigid.freezeRotation = false;
            rigid.AddForce(new Vector2(-30f, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rigid.AddForce(new Vector2(0, 500f), ForceMode2D.Force);
        }
    }
}
