using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Should be on the Canvas object
public class SubsUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI subtitleText = default;

    public static SubsUI instance;

    private void Awake()
    {
        instance = this; 
        ClearSubtitle();
    }

    public void SetSubtitle(string subtitle, float delay)
    {
        subtitleText.text = subtitle;

        StartCoroutine(ClearSubsAfterSecond(delay));
    }

    public void ClearSubtitle()
    {
        subtitleText.text = "";
    }

    private IEnumerator ClearSubsAfterSecond(float delay)
    {
        yield return new WaitForSeconds(delay);
        ClearSubtitle();
    }

}

