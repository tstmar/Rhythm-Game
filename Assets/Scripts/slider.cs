using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slider : MonoBehaviour
{
    public GameObject sliderObject;
    public bool canBePressed;
    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        canBePressed = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyToPress))
        {
            if (canBePressed)
            {
                float y = sliderObject.transform.localScale.y;
                Color oldCol = this.GetComponent<MeshRenderer>().material.color;
                if(oldCol.a >= 0f)
                {
                    Color newCol = new Color(oldCol.r, oldCol.g, oldCol.b, oldCol.a - (13.2f / y / 50f));
                    this.GetComponent<MeshRenderer>().material.color = newCol;
                }
            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        canBePressed = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canBePressed = false;
        Color color = this.GetComponent<MeshRenderer>().material.color;
        if (color.a >= 0.2f)
        {
            GameManager.instance.NoteMissed();
        } else
        {
            GameManager.instance.NoteHit();
        }
    }
}
