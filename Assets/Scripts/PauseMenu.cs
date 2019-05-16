using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
    
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
