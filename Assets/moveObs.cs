using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveObs : MonoBehaviour
{
    private int startPoint = 20;
    private int endPoint = -20;
    public GameObject bolt;

    // Start is called before the first frame update
    void Start()
    {
        
        bolt.transform.position = new Vector3(transform.position.x, startPoint, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        bolt.transform.Translate(Vector3.down * 10 * Time.deltaTime);

        if (bolt.transform.position.y <= endPoint)
        {
            bolt.transform.position = new Vector3(transform.position.x, startPoint, transform.position.z);
        }
    }
}
