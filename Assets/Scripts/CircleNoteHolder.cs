using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleNoteHolder : MonoBehaviour
{
    public Material Material1;
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Object.GetComponent<MeshRenderer>().material = Material1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
