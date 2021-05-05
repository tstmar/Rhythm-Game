using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyUp(keyToPress))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
