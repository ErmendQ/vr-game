using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPopup : MonoBehaviour
{
    public GameObject popupPanel;
    public float popupDuration = 5f;
    private float timer;
    void Start()
    {
        popupPanel.SetActive(true);
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= popupDuration)
        {
            popupPanel.SetActive(false);
        }
    }
}
