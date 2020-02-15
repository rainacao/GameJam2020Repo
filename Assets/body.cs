using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("n"))
        {
            rigid.AddForce(new Vector2(force, 0), ForceMode2D.Force);
        }
        if (Input.GetKey("c"))
        {
            rigid.AddForce(new Vector2(-force, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rigid.AddForce(new Vector2(0, force), ForceMode2D.Force);
        }
    }
}
