using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubsUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI subtitleText;

    public static SubsUI instance;

    private void Awake()
    {
        instance = this; 
    }

    public void SetSubtitle(string subtitle)
    {
        subtitleText.text = subtitle;
    }
}

