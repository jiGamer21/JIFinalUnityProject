using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI finalScoreText;

    public Button startButton; //to start the game from the main menu
    public Button mainMenuButton; //to return to the main menu of the game
    public Button creditsButton; //to read the credits of the game
    public Button restartButton; //to restart the game

    public GameObject gameOverScreen;
    public GameObject titleScreen;
    public GameObject inGameScreen;

    public bool isGameActive;

    // Start is called before the first frame update
    public void StartGame()
    {
        isGameActive = true;
        gameOverScreen.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(false);
        inGameScreen.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver ()
    {
        gameOverScreen.gameObject.SetActive(true);
        isGameActive = false;
        finalScoreText.text = "Your Score: " + score;

    }
    
}
