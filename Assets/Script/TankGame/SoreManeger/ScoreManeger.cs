using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    public string Playername;
    public int Score = 0;

    public playerspawner spawner;
    public GameObject GameoverUI;
    public Text scoreText,finalScoreText,hightscore;
    public Text hptext;

    void Start()
    {
        spawner = FindObjectOfType<playerspawner>();
        GameoverUI = GameObject.Find("Gameover");
        GameoverUI.SetActive(false);
    }


    void Update()
    {
        scoreText.text = "SCORE:" + Score;
        hptext.text = ":" + spawner.hp;

        if(spawner.hp <= 0)
        {
            Endgame();
        }
    }

    void Endgame()
    {
        GameoverUI.SetActive(true);
        finalScoreText.text = "SCORE:" + Score;

        Time.timeScale = 0;
    }
}
