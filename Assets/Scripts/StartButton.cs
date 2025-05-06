using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //public int gameStartScene;
    // Start is called before the first frame update
    void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
