using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpaceSubs : MonoBehaviour
{
    //Stay in front of player
    //Adjust the Y rotation to face the player
    //Adjust the X rotation to face the player
    //Only do this if the subtitles are active
    Camera cam;
    Canvas subCanvas;

    float targetYRotation;
    float currentYRotation;

    float maxYAngleDistance;
    float currentYVelocity;

    [SerializeField] float smoothSpeed = 1f; 

    private void Start()
    {
        cam = FindAnyObjectByType<Camera>();
    }
    void SubsRotateY()
    {
        targetYRotation = cam.transform.rotation.eulerAngles.y;
        currentYRotation = subCanvas.transform.parent.rotation.eulerAngles.y;

        float distance = Mathf.Abs(currentYRotation - targetYRotation);

        if (distance > maxYAngleDistance)
        {
            //alligne with player function
        }
    }

    void AlligneWithPlayer()
    {
        //currentYVelocity = 

        //float newAngle = Mathf.SmoothDampAngle(currentYRotation, targetYRotation, ref currentYVelocity, Time.deltaTime * smoothSpeed);
    }
}
