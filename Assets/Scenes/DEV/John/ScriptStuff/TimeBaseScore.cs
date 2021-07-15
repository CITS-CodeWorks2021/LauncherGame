using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBaseScore : MonoBehaviour
{
    float currentScore;
    int scoreMultiplier;
    UnityEngine.UI.Text scoreDisplay;

    bool isPlaying;

    private void Update()
    {
        if (!isPlaying) return;
        currentScore += Time.deltaTime * scoreMultiplier;


        int displayScore = (int)currentScore;
        scoreDisplay.text = displayScore.ToString();
    }

    public void PickUp(int scoreBonus)
    {
        currentScore += scoreBonus;
    }

    public void StartGame()// 'ish :)
    {
        isPlaying = true;
        currentScore = 0;
    }

    public void EndGame()
    {
        isPlaying = false;
        //Final Score Display code. . .
    }
}
