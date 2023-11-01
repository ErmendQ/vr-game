using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public int minIntensity = 1;
    public int maxIntensity = 10;
    public float flickerSpeed = 1.0f;
    private Light lightSource;

    void Start()
    {
        lightSource = GetComponent<Light>();
        StartFlickering();
    }
    void StartFlickering()
    {
        InvokeRepeating("Flicker", 0.0f, flickerSpeed);
    }
    void Flicker()
    {
        int randomIntensity = Random.Range(minIntensity, maxIntensity + 1); 
        lightSource.intensity = randomIntensity;
    }
}
