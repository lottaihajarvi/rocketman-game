using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource bgMusic;
    public AudioSource deathMusic;

    public bool bgAudio = true;
    public bool deathAudio = false;

    public void BgMusicPlay()
    {
        bgAudio = true;
        deathAudio = false;

        bgMusic.Play();
    }

    public void GameOverPlay()
    { 
        if (bgMusic.isPlaying)
        {
            bgAudio = false;
            bgMusic.Stop();
        }
            
        if (!deathMusic.isPlaying && deathAudio == false)
        {
            deathAudio = true; 
            deathMusic.Play();
        }
    }
}
