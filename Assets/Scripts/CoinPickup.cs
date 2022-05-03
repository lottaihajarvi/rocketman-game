using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{

    private int coins = 0;
    public Text scoreText;
    public GameObject finishGoal;
    public AudioSource pickupCoin;

    void Start()
    {
        pickupCoin = GetComponent<AudioSource> ();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            scoreText.text = "Coins: " + coins + "/10";
            pickupCoin.Play();
        }

        if (coins >= 10)
        {
            spawnGoal();
            scoreText.text = "Goal appeared!";
        }

    }

    void spawnGoal()
    {
        finishGoal.SetActive(true);
    }
}
