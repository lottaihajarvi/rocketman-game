using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("MainLevel");
        FindObjectOfType<AudioManager>().BgMusicPlay();
        Time.timeScale = 1f;
    }

    public void CloseGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
