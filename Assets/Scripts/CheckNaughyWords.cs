using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckNaughyWords : MonoBehaviour
{

    public TMP_InputField inputField;

    public TextAsset textassetblocklist;
    [SerializeField] string[] strBlockList;
    public string badwordtest;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        strBlockList = textassetblocklist.text.Split(new string[] { "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
    }

    void BadWordCheck()
    {
        Debug.Log(inputField.text);

        if (inputField.text.ToLower().Contains(badwordtest))
        {
            Debug.LogWarning("you did a badtest");
            Application.Quit();
        }

        Debug.LogWarning(strBlockList[5]);
            if (inputField.text == strBlockList[5])
            {
                Debug.LogWarning("wtf");
            }
            else
            {
                Debug.Log("nope");
            }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
