using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserStart : MonoBehaviour
{
    LineRenderer lineRenderer;
    [SerializeField] float laserDistance = 8f;
    [SerializeField] LayerMask ignoreMask;
    [SerializeField] UnityEventQueueSystem OnHitTarget;

    RaycastHit rayHit;
    Ray ray;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }
    private void Update()
    {
        ray = new(transform.position, transform.forward);

        if(Physics.Raycast(ray, out rayHit, laserDistance, ~ignoreMask))
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, rayHit.point);

            if (rayHit.collider.TryGetComponent(out LaserTarget target))
            {
                target.LaserHit();
            }
        }
        else
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position + transform.forward * laserDistance);
        } 
            
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * laserDistance);
    }
}
