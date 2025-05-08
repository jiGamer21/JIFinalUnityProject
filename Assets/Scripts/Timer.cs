// Thank you John French from gamedevbeginner for the tutorial for the timer
// https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeLeft;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find ("GameManager").GetComponent<GameManager>();
        // Starts the timer automatically
        timerIsRunning = true;
        
    }
    // public void StartGame()
    // {
                
    // }
    void Update()
    {
        //if (gameManager.isGameActive)
        //{
        //    timerIsRunning = true;
        //}

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
                gameManager.GameOver();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeLeft.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}