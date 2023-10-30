using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Should be on the player object 
public class VocalManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static VocalManager instance;

    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayAudio(AudioObject clip)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        audioSource.PlayOneShot(clip.clip);

        SubsUI.instance.SetSubtitle(clip.subtitle, clip.clip.length);
    }
}
