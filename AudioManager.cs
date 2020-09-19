using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public bool isMute = false;

    private AudioSource audioSrc;
    [SerializeField] AudioClip[] sounds;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        audioSrc = GetComponent<AudioSource>();
    }
    void Start()
    {
        

    }

    public void PlaySound( string sound, float volume)
    {
        if (!isMute)
        {
            switch (sound) {
                case "sound1":
                    audioSrc.PlayOneShot(sounds[0], volume);
                    break;
                
                case "sound2":
                    audioSrc.PlayOneShot(sounds[1], volume);
                    break;
                
                case "sound3":
                    audioSrc.PlayOneShot(sounds[2], volume);
                    break;

                case "sound4":
                    audioSrc.PlayOneShot(sounds[3], volume);
                    break;
                case "stop":
                    audioSrc.Stop();
                    break;
                default:
                    Debug.LogError("There is no such sound clip");
                    
                    break;

            }

        }

    }

}
