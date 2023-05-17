using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenuScene");
    }

    public void GameQuit()
    {
        Application.Quit();
    }

}
