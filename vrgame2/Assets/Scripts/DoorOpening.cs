using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;
    public float openDistance = 3.0f;
    public float openSpeed = 2.0f;

    private Vector3 initialLeftDoorPosition;
    private Vector3 initialRightDoorPosition;
    private Vector3 targetLeftDoorPosition;
    private Vector3 targetRightDoorPosition;
    private bool isOpen = false;

    public Camera camera;
    public float interactionDistance = 5f; // Adjust the interaction distance

    void Start()
    {
        // Store the initial positions of the left and right doors
        initialLeftDoorPosition = leftDoor.transform.position;
        initialRightDoorPosition = rightDoor.transform.position;

        // Calculate the target positions for the doors when they're open
        targetLeftDoorPosition = initialLeftDoorPosition - Vector3.right * openDistance;
        targetRightDoorPosition = initialRightDoorPosition + Vector3.right * openDistance;
    }

    void Update()
    {
        // Move the doors towards their target positions
        if (isOpen)
        {
            leftDoor.transform.position = Vector3.Lerp(leftDoor.transform.position, targetLeftDoorPosition, Time.deltaTime * openSpeed);
            rightDoor.transform.position = Vector3.Lerp(rightDoor.transform.position, targetRightDoorPosition, Time.deltaTime * openSpeed);
        }
        else
        {
            leftDoor.transform.position = Vector3.Lerp(leftDoor.transform.position, initialLeftDoorPosition, Time.deltaTime * openSpeed);
            rightDoor.transform.position = Vector3.Lerp(rightDoor.transform.position, initialRightDoorPosition, Time.deltaTime * openSpeed);
        }

        // Calculate the distance from the player to the button
        float distanceToPlayer = Vector3.Distance(transform.position, camera.transform.position);

        // Check if the button is within the interaction distance and the "E" key is pressed
        if (distanceToPlayer <= interactionDistance && Input.GetKeyDown(KeyCode.E))
        {
            ToggleDoor();
        }
    }

    void ToggleDoor()
    {
        isOpen = !isOpen;
    }
}