using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextstage : MonoBehaviour
{

    public ScoreManeger scoreManeger;
    public playerspawner spawner;
    void Start()
    {
        Time.timeScale = 1;
        scoreManeger = FindObjectOfType<ScoreManeger>();
        spawner = FindObjectOfType<playerspawner>();
        setoldscore();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setoldscore()
    {
        scoreManeger.Score = PlayerPrefs.GetFloat("Scoretoplayer");
        scoreManeger.Playername = PlayerPrefs.GetString("Playertoplay");
        spawner.hp = PlayerPrefs.GetInt("Hptoplay");
    }
}
