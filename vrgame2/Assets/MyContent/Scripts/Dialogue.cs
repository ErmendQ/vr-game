using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] subLines;
    [SerializeField] float textSpeed;
    [SerializeField] float nextLineSpeed = 5;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        
        
    }


    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());


    }

    void NextLine()
    {
        if (index < subLines.Length - 1)
        {
            index++;
            Debug.Log(index);
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
          
        }
        else
        {
            gameObject.SetActive(false);
           
        }
    }

    IEnumerator TypeLine()
    {
        foreach(char c in subLines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return  new  WaitForSeconds(textSpeed);
        }
       
        yield return new WaitForSeconds(nextLineSpeed);
        NextLine();

    }

}
