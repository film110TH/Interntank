using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public playerspawner spawner;
    void Start()
    {
        spawner = FindObjectOfType<playerspawner>();
    }

    public void startgame()
    {
        SceneManager.LoadScene("stage1");
    }
    public void loadStage1to2()
    {
        if(spawner.hp>0)
            SceneManager.LoadScene("stage2");
        else
            SceneManager.LoadScene("Menu");
    }
    public void LoadStagetoendless()
    {

    }
}
