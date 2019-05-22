using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour

{
    
    public GameObject pauseMenuUI;
    bool gameIsPaused = false;
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject compeleteLevelUI;
    public void CompleteLevel()
    {
        compeleteLevelUI.SetActive(true);

        {

        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                Time.timeScale = 1f;
            }

            else
            {
                Pause();
                Time.timeScale = 0f;
            }

        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    

}
