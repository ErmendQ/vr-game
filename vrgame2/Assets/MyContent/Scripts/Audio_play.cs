using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_play : MonoBehaviour
{
    AudioSource aud;
    Animator animator;
    bool currentAnimatorState;
    public AudioClip walkingNoise;
    // Start is called before the first frame update
    void Start()
    {
        aud= GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        play_sound();
    }
    public void  play_sound()
    {
         currentAnimatorState = animator.enabled ;
            if (currentAnimatorState == true && !aud.isPlaying)
        {
            aud.Play();
            Debug.Log("test");
        }
                

    }
}
