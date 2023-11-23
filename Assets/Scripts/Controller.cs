using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class Controller : MonoBehaviour
{
    public TMP_Text viewsText;

    public double views; 


    public void Update()
    {
        viewsText.text = views + " Views"; 
    }

    public void GernerateViews()
    {
        Debug.Log("you have earned views"); 
        
        views ++; 

    }
}
