using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCounter : MonoBehaviour
{
    public int variableToIncrement = 0; 
    public int neededCount = 3;     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementAndCheck()
    {
        variableToIncrement++;

        // Check if the variable has reached the limit
        if (variableToIncrement >= neededCount)
        {
            // Destroy the door GameObject
            Destroy(gameObject);
        }
    }
}
