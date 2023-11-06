using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public GameObject DeathUI;
    
    [SerializeField] private int Health = 2;

    private void Start()
    {
        DeathUI = GameObject.FindGameObjectWithTag("DeathUI"); 
        DeathUI.SetActive(false);
        Health = 2;
        Time.timeScale = 1;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Health -= 1;
        }
        if (Health <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        DeathUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
