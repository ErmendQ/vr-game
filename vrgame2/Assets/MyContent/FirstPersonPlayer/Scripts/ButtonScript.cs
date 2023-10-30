using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Light[] lights; // An array of lights to control
    public float interactionDistance = 5f; // Adjust the interaction distance
    private bool isLightOn = false;
    public Camera camera;

    void Update()
    {
        // Calculate the distance from the player to the button
        float distanceToPlayer = Vector3.Distance(transform.position, camera.transform.position);

        // Check if the button is within the interaction distance and the "E" key is pressed
        if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(KeyCode.E))
        {
            ToggleLights();
        }
    }

    void ToggleLights()
    {
        isLightOn = !isLightOn;

        foreach (Light light in lights)
        {
            light.enabled = isLightOn;
        }
    }
}
