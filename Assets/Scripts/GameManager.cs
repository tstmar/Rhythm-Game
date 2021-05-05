using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject note5;
    public GameObject note6;
    public GameObject note7;
    public GameObject note8;

    public GameObject sliderDarkBlue;
    public GameObject sliderDarkPurple;
    public GameObject sliderLightBlue;
    public GameObject sliderLightPurple;

    public GameObject NoteHolder;

    public TextAsset musicNotes;
    string[] lines;
    int i;
    int location;
    float hitTime;
    int type;
    float sliderTime;

    float timer = 0f;

    public Text scoreText;
    public Text comboText;
    public Canvas scoreBoard;
    public float currentScore;
    public int scorePerNote = 100;
    public int combo = 0;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (startPlaying)
        {
            
            timer += Time.deltaTime;
            if (timer * 1000f + 1000f >= hitTime)
            {
                
                if (location == 0)
                {
                    GameObject bottomLeft = Instantiate(note1, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    bottomLeft.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderDarkBlue, new Vector3(-1.47f, 0.55f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime/1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 1)
                {
                    GameObject bottomMiddleLeft = Instantiate(note2, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    bottomMiddleLeft.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderLightPurple, new Vector3(-3.39f, 2.47f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 2)
                {
                    GameObject topMiddleLeft = Instantiate(note3, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    topMiddleLeft.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderLightPurple, new Vector3(-3.51f, 5.31f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 3)
                {
                    GameObject topLeft = Instantiate(note4, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    topLeft.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderLightBlue, new Vector3(-1.47f, 7.44f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 4)
                {
                    GameObject topRight = Instantiate(note5, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    topRight.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderLightBlue, new Vector3(1.47f, 7.44f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 5)
                {
                    GameObject topMiddleRight = Instantiate(note6, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    topMiddleRight.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderDarkPurple, new Vector3(3.51f, 5.31f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 6)
                {
                    GameObject bottomMiddleRight = Instantiate(note7, new Vector3(0f, 4f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    bottomMiddleRight.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderDarkPurple, new Vector3(3.39f, 2.47f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                if (location == 7)
                {
                    GameObject bottomLeft = Instantiate(note8, new Vector3(1.47f, 0.55f, 20f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                    bottomLeft.transform.SetParent(NoteHolder.transform);
                    if (type == 1)
                    {
                        GameObject sliderNote = Instantiate(sliderDarkBlue, new Vector3(1.47f, 0.55f, 20.1f), Quaternion.Euler(new Vector3(90f, 0, 0)));
                        sliderNote.transform.localScale = new Vector3(1f, (13.2f) * sliderTime / 1000, 1f);
                        sliderNote.transform.SetParent(NoteHolder.transform);
                    }
                }
                i++;
                CalculateNoteAttribute(lines[i]);
            }
        }

    }

    public void CalculateNoteAttribute(string line)
    {
        
        string[] attributes = line.Split(","[0]);
        type = Mathf.RoundToInt(float.Parse(attributes[0]));
        location = Mathf.RoundToInt(float.Parse(attributes[1])*8f);
        hitTime = float.Parse(attributes[2]);
        if (type == 1)
        {
            sliderTime = float.Parse(attributes[3]) - hitTime;
        }

    }

    public void NoteHit()
    {
        currentScore += Mathf.RoundToInt(scorePerNote * (1 + combo*.1f));
        scoreText.text = "Score: " + currentScore;
        combo += 1;
        comboText.text = "Combo: " + combo + "x";

    }

    public void NoteMissed()
    {
        combo = 0;
        comboText.text = "Combo: " + combo + "x";
    }

    public void startGame(TextAsset newMusicNotes, AudioSource newMusic)
    {
        timer += Time.deltaTime;
        theMusic.Stop();
        Debug.Log(theMusic);
        timer = 0f;
        musicNotes = newMusicNotes;
        theMusic = newMusic;
        currentScore = 0;
        startPlaying = true;
        theBS.hasStarted = true;
        theMusic.Play();
        lines = musicNotes.text.Split("\n"[0]);
        i = 0;
        CalculateNoteAttribute(lines[i]);
    }
}
