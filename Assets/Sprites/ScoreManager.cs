using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreBlueText;
    public Text scoreRedText;
    public Text scoreGreenText;
    public int scoreBlue;
    public int scoreRed;
    public int scoreGreen;
   
    void Start()
    {
        scoreBlue = 0;
        scoreRed = 0;
        scoreGreen = 0;
       
        //UpdateScore();
    }



    void UpdateScore()
    {
        scoreBlueText.text = ": " + scoreBlue;
        scoreRedText.text = ": " + scoreRed;
        scoreGreenText.text = ": " + scoreGreen;
        
    }
    public void AddScoreBlue(int newScoreValueBlue)
    {
        scoreBlue ++;
        UpdateScore();
    }

    public void AddScoreRed(int newScoreValueRed)
    {
        scoreRed ++;
        UpdateScore();
    }

    public void AddScoreGreen(int newScoreValueGreen)
    {
        scoreGreen += newScoreValueGreen;
        UpdateScore();
    }

    
}
