using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject instanceObject;
    public float speed;
    public Vector3 objectPosition = new Vector3(0, 0, 0);
    public Vector3 pos = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        pos.y = 0;
        pos.x = 0;
        pos.z = 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(instanceObject, transform.position, Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y = 1;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            pos.y = -1;
        }

        transform.Translate(pos * speed * Time.deltaTime);
    }
}
