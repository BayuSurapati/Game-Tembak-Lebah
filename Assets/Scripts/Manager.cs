using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int score = 0;
    public float myFloat;
    public string saveName;
    // Start is called before the first frame update
    void Start()
    {
        LoadScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveScore();
        }
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("MyFloat", myFloat);
        PlayerPrefs.SetString("SaveName", saveName);
    }

    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("Score");
        myFloat = PlayerPrefs.GetFloat("MyFloat");
        saveName = PlayerPrefs.GetString("SaveName");
    }
}
