using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float moveSpeed = 5f;
    public Camera cameraRef;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        // Check if the object is visible on the camera
        Vector3 viewportPos = cameraRef.WorldToViewportPoint(transform.position);
        agent.SetDestination(player.position);
        agent.speed = 0;

        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            // The object is not in the camera's viewport, move towards the player
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            //transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
            agent.speed = moveSpeed;
        }
    }
}
