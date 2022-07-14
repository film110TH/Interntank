using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    public string Playername;
    public float Score = 0;
    public int enemytikill;

    public playerspawner spawner;
    public EnemySpawn enemySpawn;

    public GameObject GameoverUI;
    public Text scoreText,finalScoreText,highscoreText;
    public Text hptext;
    public GameObject Gameovertext, completetext;

    void Start()
    {
        spawner = FindObjectOfType<playerspawner>();
        enemySpawn = FindObjectOfType<EnemySpawn>();
        GameoverUI = GameObject.Find("Gameover");
        GameoverUI.SetActive(false);
        enemytikill = enemySpawn.EnemyCount;
    }


    void Update()
    {
        scoreText.text = "SCORE:" + Score;
        hptext.text = ":" + spawner.hp;

        if (spawner.hp <= 0)                
            Endgame();
        
        if(enemytikill <=0&& spawner.hp != 0)
        {
            Endgame();
            PlayerPrefs.SetInt("Hptoplay", spawner.hp);
            PlayerPrefs.SetFloat("Scoretoplayer", Score);
            PlayerPrefs.Save();
        }
            

        if (Input.GetKeyDown(KeyCode.K))        
            Endgame();

        if (Input.GetKeyDown(KeyCode.J))
        {
            PlayerPrefs.DeleteKey("Highscore");
            PlayerPrefs.DeleteKey("Playerhighscore");
        }
    }

    void Endgame()
    {
        checkhighscore();
        GameoverUI.SetActive(true);
        if(spawner.hp <= 0)
        {
            Gameovertext.SetActive(true);
            completetext.SetActive(false);
        }
        else
        {
            Gameovertext.SetActive(false);
            completetext.SetActive(true);
        }
        finalScoreText.text = "SCORE:" + Score;      
        highscoreText.text = "High score:" + PlayerPrefs.GetString("Playerhighscore") + " " + PlayerPrefs.GetFloat("Highscore"); 

        Time.timeScale = 0;
    }

    void checkhighscore()
    {
        if (PlayerPrefs.HasKey("Highscore"))
        {
            float checkscore = PlayerPrefs.GetFloat("Highscore");
            if(checkscore < Score)
            {
                PlayerPrefs.SetFloat("Highscore", Score);
                PlayerPrefs.SetString("Playerhighscore", Playername);
                PlayerPrefs.Save();
            }
        }
        else
        {
            PlayerPrefs.SetFloat("Highscore", Score);
            PlayerPrefs.SetString("Playerhighscore", Playername);
            PlayerPrefs.Save();
        }
    }

    
}
