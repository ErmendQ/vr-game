using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float moveSpeedWhenNotInView = 5f;
    public float moveSpeedWhenInView = 0f; // Set to 0 for no movement when in view
    public Camera cameraRef;

    private NavMeshAgent agent;
    private Animator animator;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    void Update()
    {
        // Check if the object is visible on the camera
        Vector3 viewportPos = cameraRef.WorldToViewportPoint(transform.position);

        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            // The object is not in the camera's viewport, move towards the player
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            agent.speed = moveSpeedWhenNotInView;
            agent.SetDestination(player.position);
            animator.enabled = true;
        }
        else
        {
            // The object is in the camera's viewport, stop moving and disable the animator
            agent.ResetPath();
            agent.speed = moveSpeedWhenInView;
            animator.enabled = false;
        }
    }
}