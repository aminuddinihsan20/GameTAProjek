using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1Jabar");
    }

    public void SettingGame()
    {
        SceneManager.LoadScene("SettingScene");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Debug.Log("Keluar dari game...");
        Application.Quit();
    }
    void Start()
    {
        Input.simulateMouseWithTouches = true;
    }

}
