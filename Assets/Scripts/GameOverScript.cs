using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{

    public GameObject player;
    public GameOverScreen GameOverScreen;

    void Start()
    {
        
    }
    
    void GameOver()
    {
        GameOverScreen.Setup();
        FindObjectOfType<AudioManager>().GameOverPlay();
    }

    void FixedUpdate()
    {
        if (Camera.main.transform.position.y > player.transform.position.y + 5)
        {
            GameOver();
            Time.timeScale = 0;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameOver();
            Time.timeScale = 0;
        }
    }

}
