using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript instance;
    bool playing = false;
    public AudioSource backgroundMusic;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        if (playing == false)
        {
            playing = true;
            backgroundMusic.Play();
        }
    }
}
