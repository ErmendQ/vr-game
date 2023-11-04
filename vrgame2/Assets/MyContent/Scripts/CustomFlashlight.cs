using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFlashlight : MonoBehaviour
{
    public Material lens;

    private Light light;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponentInChildren<Light>();
        audioSource = GetComponent<AudioSource>();
    }

   public void LightOn()
    {
        audioSource.Play();
        lens.EnableKeyword("_EMISSION");
        light.enabled = true;
    }

    public void LightOff()
    {
        audioSource.Play();
        lens.DisableKeyword("_EMISSION");
        light.enabled=false;
    }
}
