using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour
{
    public AudioSource theMusic;
    public TextAsset musicNotes;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("hello");
        GameManager.instance.startGame(musicNotes, theMusic);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
