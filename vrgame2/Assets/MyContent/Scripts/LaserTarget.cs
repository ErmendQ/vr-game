using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTarget : MonoBehaviour
{
    [SerializeField]
    PlayerDeath playerDeath;

    private void Start()
    {
        playerDeath = GetComponent<PlayerDeath>();
    }
    public void LaserHit()
    {
        Debug.Log("Laser Hit");
        playerDeath.Health -= .5f;
    }
}
