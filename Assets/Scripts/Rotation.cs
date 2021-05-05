using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public KeyCode moveRight;
    public KeyCode moveLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(moveRight))
        {
            transform.Rotate(0f, 0f, 10f);
        }
        if (Input.GetKey(moveLeft))
        {
            transform.Rotate(0f, 0f, -10f);
        }
    }
}
