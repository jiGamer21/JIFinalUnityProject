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
    public Button mainMenuButtonCredits; //to return to the previous screen

    public GameObject gameOverScreen;
    public GameObject titleScreen;
    public GameObject inGameScreen;
    public GameObject creditsScreen;

    // public Timer timer;

    public bool isGameActive;

    // Start is called before the first frame update
    public void Start()
    {
        isGameActive = false;
        gameOverScreen.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        creditsButton.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(true);
        inGameScreen.gameObject.SetActive(false);
        creditsScreen.gameObject.SetActive(false);
        
        //startButton.onClick.AddListener(StartGame());

    }
    public void StartGame()
    {
        isGameActive = true;
        gameOverScreen.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(false);
        inGameScreen.gameObject.SetActive(true);
        creditsScreen.gameObject.SetActive(false);
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
        startButton.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(false);
        inGameScreen.gameObject.SetActive(false);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        mainMenuButton.gameObject.SetActive(true);
        mainMenuButtonCredits.gameObject.SetActive(false);
        creditsScreen.gameObject.SetActive(false);       
        finalScoreText.text = "Your Score: " + score;
        //restartButton.gameObject.SetActive(true);

    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   // public 
   public void CreditsScreen()
   {
        gameOverScreen.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(false);
        inGameScreen.gameObject.SetActive(false);
        isGameActive = false;
        restartButton.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);
        mainMenuButtonCredits.gameObject.SetActive(true);
        creditsScreen.gameObject.SetActive(true);
   }
}
