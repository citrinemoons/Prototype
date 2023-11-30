using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class Controller : MonoBehaviour
{
    public TMP_Text viewsText;
    public GameObject SingleMessageBan;
    public Button StreamButton;

    public double views;

    public UpgradesManager upgradesManager;

    public float timer;
    public float streambottimer;
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

        if (upgradesManager.streambots >=  1)
        {
            if (timer > streambottimer)
            {
                StreamButton.onClick.Invoke();
                timer = 0f;
            }
        }



    }
    public void CheckBan(GameObject TheMessage)
    {

        if (SingleMessageBan != null)
        {

            SingleMessageBan = TheMessage;

        }
        else
        {
            SingleMessageBan = null;
        }
    }
}
