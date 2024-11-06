using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusic;
    public AudioClip[] sfxClips;

    private Dictionary<string, AudioClip> sfxClipsDict;

    private void Awake()
    {
        // Ensure that there is only one instance of the SoundManager (Singleton Pattern)
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Make this persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate SoundManagers
            return;
        }

        // Initialize the dictionary with SFX clips for easy access
        sfxClipsDict = new Dictionary<string, AudioClip>();
        foreach (var clip in sfxClips)
        {
            sfxClipsDict[clip.name] = clip;
        }

        // Play background music if available
        if (backgroundMusic != null && musicSource != null)
        {
            PlayMusic(backgroundMusic);
        }
    }

    // Play background music
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

    // Play a sound effect by name
    public void PlaySFX(string clipName)
    {
        if (sfxClipsDict.TryGetValue(clipName, out AudioClip clip))
        {
            sfxSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning("Sound clip not found: " + clipName);
        }
    }

    // Stop background music
    public void StopMusic()
    {
        musicSource.Stop();
    }
}
