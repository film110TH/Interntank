using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Textonspot : MonoBehaviour
{
    public string DisplayText;
    public int DisplayPoints;
    public Text Textprefab;
    public float speed;
    public float DestroyAfter;
    private float Timer;

    void Start()
    {
        Timer = DestroyAfter;   
        Textprefab = GetComponentInChildren<Text>();
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
            Destroy(gameObject);

        if (DisplayPoints > 0)
            Textprefab.text = "+" + DisplayPoints +"p";
        else if (DisplayText != null)
            Textprefab.text = DisplayText;

        if (speed > 0)
            transform.Translate(Vector3.up* speed * Time.deltaTime, Space.World);
    }
}
