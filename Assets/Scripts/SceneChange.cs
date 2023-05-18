using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void GameStart()
    {
        StartCoroutine(GameStartSoundAwait());
    }

    public void MainMenu()
    {
        StartCoroutine(MainMenuAwait());
    }

    public void GameQuit()
    {
        StartCoroutine(GameSoundQuitAwait());
    }
    
    IEnumerator GameStartSoundAwait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Scenes/GameScene");
    }

    IEnumerator GameSoundQuitAwait()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }

    IEnumerator MainMenuAwait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Scenes/MainMenuScene");
    }
}
