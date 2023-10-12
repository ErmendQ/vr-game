using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float moveSpeed = 5f;
    public Camera cameraRef;

    void Update()
    {
        // Check if the object is visible on the camera
        Vector3 viewportPos = cameraRef.WorldToViewportPoint(transform.position);

        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            // The object is not in the camera's viewport, move towards the player
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }
    }
}
