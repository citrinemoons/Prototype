using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public Controller Controller;

    [Header("Streambots")]
    public int streambots;
    public float streambotcost;
    public float streambotincome;
    public GameObject StreamBotButton;
    public TextMeshProUGUI StreambotVal;
    [Header("Click Upgrades")]
    public int clickupgrades;
    public float clickupgradescost;
    public GameObject clickupgradebutton;
    public TextMeshProUGUI ClickUpgradeVal;
    [Header("Totals")]
    public float totalmultiplier;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        StreambotVal.text = $"Amount : {streambots}";
        ClickUpgradeVal.text = $"Amount : {clickupgrades}";

        float streambotf = streambots;
        float streamtotalcost = Mathf.Pow((streambotcost * 1.06f), streambotf);

        StreamBotButton.GetComponent<PurchaseUpgrade>().cost = streamtotalcost;

        totalmultiplier = streambots * streambotincome;

        //todoclick button.
        //I did alot of this very quickly but I will explain tomorrow

    }

    public void PurchaseUpgrade(string Upgrade)
    {

        if (Upgrade == "Bot")
        {
            streambots++;
            Controller.views -= StreamBotButton.GetComponent<PurchaseUpgrade>().cost;
        }



    }

}
