using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VocalTrigger : MonoBehaviour
{
    public AudioObject clipToPlay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VocalManager.instance.PlayAudio(clipToPlay);
            Debug.Log("It collided");
        }
    }
}
