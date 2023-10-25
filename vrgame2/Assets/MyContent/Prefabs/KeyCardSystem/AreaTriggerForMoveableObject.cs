using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTriggerForMoveableObject : MonoBehaviour
{
    public GameObject targetObject;  // Reference to the object you want to detect
    public GameObject doorToOpen;  // Reference to the object you want to destroy

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            // The specific object has entered the trigger area
            // You can destroy the object here
            if (doorToOpen != null)
            {
                Destroy(doorToOpen);
                Debug.Log("Object entered the trigger area and was destroyed.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            // The specific object has exited the trigger area
            Debug.Log("Object exited the trigger area");
        }
    }
}
