using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject DeathUI;

    [SerializeField] private int Health = 2;

    private void Start()
    {
        DeathUI = GameObject.FindGameObjectWithTag("DeathUI"); 
        DeathUI.SetActive(false);
        Health = 2; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Health -= 1;
        }
    }

    private void Death()
    {
        if (Health <= 0)
        {
            DeathUI.SetActive(true);

        }
    }
}
