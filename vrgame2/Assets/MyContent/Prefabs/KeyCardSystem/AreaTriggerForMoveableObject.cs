using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTriggerForMoveableObject : MonoBehaviour
{
    public GameObject targetObject;  
    public DoorCounter doorToOpen;  
    private bool hasInteracted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasInteracted && other.gameObject == targetObject)
        {
            doorToOpen.IncrementAndCheck();
            hasInteracted = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == targetObject)
        {
            Debug.Log("Object exited the trigger area");
        }
    }
}
