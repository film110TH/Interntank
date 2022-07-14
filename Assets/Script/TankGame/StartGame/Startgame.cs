using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Startgame : MonoBehaviour
{

    public GameObject fieldname;
    public ScoreManeger scoreManeger;
    public playerspawner Playerspawner;
    void Start()
    {
        Time.timeScale = 0f;
        scoreManeger = FindObjectOfType<ScoreManeger>();
        Playerspawner = FindObjectOfType<playerspawner>();
        resetplayer();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEntername(string name)
    {
        Debug.Log(name);
        scoreManeger.Playername = name;
        fieldname.gameObject.SetActive(false);
        SetPlayertoplay();
        Time.timeScale = 1f;
        
    }

    void resetplayer()
    {
        PlayerPrefs.DeleteKey("Playertoplay");
        PlayerPrefs.DeleteKey("Hptoplay");
        PlayerPrefs.DeleteKey("Scoretoplayer");
        PlayerPrefs.Save();
    }
    void SetPlayertoplay()
    {
        PlayerPrefs.SetString("Playertoplay", scoreManeger.Playername);
        PlayerPrefs.SetInt("Hptoplay", Playerspawner.hp);
        PlayerPrefs.SetFloat("Scoretoplayer", scoreManeger.Score);
        PlayerPrefs.Save();
    }
}
