using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menumaneger : MonoBehaviour
{
    public GameObject highscorepage;
    public Text hightscore;

    public GameObject tutorialpage;
    public GameObject[] intutorialpage;
    public int numpageutorial = 0;

    int numberofallpage;
    void Start()
    {
        highscorepage.SetActive(false);     
        if(tutorialpage !=null)
            tutorialpage.SetActive(false);

        numberofallpage = intutorialpage.Length;
    }

    void Update()
    {
        if (highscorepage.active == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                highscorepage.SetActive(false);
                Time.timeScale = 1;

            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                onshowhighscore();
                Time.timeScale = 0;
            }
        }

     
    }

    void checktutorail()
    {
        if (tutorialpage.active == true && numpageutorial < 0 || numpageutorial > numberofallpage - 1)
        {
            tutorialpage.SetActive(false);
            numpageutorial = 0;
        }
        foreach (GameObject item in intutorialpage)
        {
            item.SetActive(false);
        }
        intutorialpage[numpageutorial].SetActive(true);
    }

    public void onshowhighscore()
    {
        highscorepage.SetActive(true);
        hightscore.text = "" + PlayerPrefs.GetString("Playerhighscore") + ":" + PlayerPrefs.GetFloat("Highscore");
    }

    public void onopentutorial()
    {
        tutorialpage.SetActive(true);
        checktutorail();
    }

    public void onnextpage()
    {
        numpageutorial++;
        checktutorail();
    }

    public void onbackpage()
    {
        numpageutorial--;
        checktutorail();
    }
}
