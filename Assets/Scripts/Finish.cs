using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{

    public GameObject victoryScreen;
    public AudioSource victorySound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            victoryScreen.SetActive(true);
            //Time.timeScale = 0;
            victorySound.Play();
        }
    }

}
