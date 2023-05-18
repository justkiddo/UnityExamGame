using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private bool _isPressed;
    
    private void Awake()
    {
        _isPressed = false;
    }

    public void GameStart()
    {
        if (_isPressed == false)
        {
            _isPressed = true;
            StartCoroutine(GameStartSoundAwait());
        }
    }

    public void MainMenu()
    {
        if (_isPressed == false)
        {
            _isPressed = true;
            StartCoroutine(MainMenuAwait());
        }
    }

    public void GameQuit()
    {
        if (_isPressed == false)
        {
            _isPressed = true;
            StartCoroutine(GameSoundQuitAwait());
        }
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
