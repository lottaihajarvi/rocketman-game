using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTransition : MonoBehaviour
{
    void Awake()
    {
        FindObjectOfType<AudioManager>().BgMusicPlay();
        DontDestroyOnLoad(transform.gameObject);
    }
}
