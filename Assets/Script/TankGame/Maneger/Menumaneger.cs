using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menumaneger : MonoBehaviour
{
    public GameObject highscorepage;
    public Text hightscore;

    void Start()
    {
        highscorepage.SetActive(false);
    }

    void Update()
    {
        if(highscorepage.active == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                highscorepage.SetActive(false);
            }
        }
    }

    public void onshowhighscore()
    {
        highscorepage.SetActive(true);
        hightscore.text = "" + PlayerPrefs.GetString("Playerhighscore") + ":" + PlayerPrefs.GetFloat("Highscore");
    }
}
