using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTurn : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float rotationSpeed = 5f; // Adjust the speed of rotation

    void Update()
    {
        rotationSpeed = Random.Range(0, 5);
        if (player != null)
        {
            // Calculate the direction from the object to the player
            Vector3 directionToPlayer = player.position - transform.position;

            // Create a rotation that points in the direction of the player
            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);

            // Modify the rotation to keep only the yaw (horizontal rotation)
            targetRotation.x = 0;
            targetRotation.z = 0;

            // Apply the modified rotation to the object
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
