using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTriggerForMoveableObject : MonoBehaviour
{
    public GameObject targetObject;
    public DoorCounter doorToOpen;
    private bool hasInteracted = false;
    private Collider keycardCollider;
    private float interactionCooldown = 100.0f; // Adjust this value as needed
    private float lastInteractionTime;

    private void Start()
    {
        keycardCollider = targetObject.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasInteracted && other.gameObject == targetObject)
        {
            if (keycardCollider.enabled)
            {
                Debug.Log("Object entered the trigger area");
                doorToOpen.IncrementAndCheck();
                hasInteracted = true;
                keycardCollider.enabled = false; 
               
            }
            else
            {
                Debug.Log("Keycard has already been used.");
            }
        }
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject == targetObject)
    //    {
    //        Debug.Log("Object exited the trigger area");
    //    }
    //}
}
