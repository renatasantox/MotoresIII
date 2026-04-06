using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    #region Private Fields

    private List<AudioSource> systemSourceChannels;
    private List<AudioSource> activeSources;
    
    #endregion
    
    #region Singleton
    public static AudioManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            systemSourceChannels = new List<AudioSource>();
            activeSources = new List<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
    
    #region Play 2D Sonds

    public void PlayMusic(AudioClip clip)
    {
        if (systemSourceChannels.Count == 0)
        {
            systemSourceChannels.Add(gameObject.AddComponent<AudioSource>());
        }
        systemSourceChannels[0].Stop();
        systemSourceChannels[0].clip = clip;
        systemSourceChannels[0].Play();
    }

    public void StopMusic()
    {
        if (systemSourceChannels.Count > 0)
    }
    
    #endregion
}

