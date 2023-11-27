using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Controller : MonoBehaviour
{
    public TMP_Text viewsText;

    public double views;

    public UpgradesManager upgradesManager;

    public float timer;
    public void Update()
    {

        
        viewsText.text = $"{Mathf.Round((float)views)} Views";
        ClickAutomation();
    }

    public void GernerateViews()
    {
        Debug.Log("you have earned views");



        views = (1 * upgradesManager.clickupgrades+1) + views;

    }

    public void ClickAutomation()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            views += upgradesManager.totalmultiplier * 1.0f;
            timer = 0f;
        }
        


    }

}
