using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
//using UnityEngine.UIElements;


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
    //public Button controlsButton; //to find out the controls
    //public Button backButton; //to return to the previous screen

    public GameObject gameOverScreen;
    public GameObject titleScreen;
    public GameObject inGameScreen;

    public bool isGameActive;

    // Start is called before the first frame update
    public void Start()
    {
        isGameActive = false;
        gameOverScreen.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(true);
        inGameScreen.gameObject.SetActive(false);
        //startButton.onClick.AddListener(StartGame());

    }
    public void StartGame()
    {
        isGameActive = true;
        gameOverScreen.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(false);
        inGameScreen.gameObject.SetActive(true);
        score = 0;
        //UpdateScore(0);

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
        //restartButton.gameObject.SetActive(true);

    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   // public 
}
