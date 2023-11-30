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
    public float streambotcostmulti;
    public float streambotcosttimerbase;
    public float streambotmultiplyer;
    public GameObject StreamBotButton;
    public TextMeshProUGUI StreambotVal;
    [Header("Click Upgrades")]
    public int clickupgrades;
    public float clickupgradescost;
    public float clickupgradescostmulti;
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
        if (streambotf > 0)
        {
            float multiplyiedcost = Mathf.Pow(streambotcostmulti, (streambotf));
            float streamtotalcost = (multiplyiedcost * streambotcost);
            StreamBotButton.GetComponent<PurchaseUpgrade>().cost = streamtotalcost;
        }
        else
        {
            StreamBotButton.GetComponent<PurchaseUpgrade>().cost = streambotcost;
        }

        Controller.streambottimer = streambotcosttimerbase / (1 + (streambotmultiplyer * (streambots-1)));


        float clickupgradef = clickupgrades;

        if (clickupgradef > 0)
        {
            float multipiedclickcost = Mathf.Pow((clickupgradescostmulti), clickupgrades);
            float clickupgradescosttemp = multipiedclickcost * clickupgradescost;
            clickupgradebutton.GetComponent<PurchaseUpgrade>().cost = clickupgradescosttemp;
        }
        else
        {
            clickupgradebutton.GetComponent<PurchaseUpgrade>().cost = clickupgradescost;
        }




        //todoclick button.
        //I did alot of this very quickly but I will explain tomorrow

    }

    public void PurchaseUpgrade(string Upgrade)
    {

        if (Upgrade == "Bot")
        {
            streambots++;
            //Controller.timer = 0f;
            Controller.views -= StreamBotButton.GetComponent<PurchaseUpgrade>().cost;
        }

        if (Upgrade == "Click")
        {
            clickupgrades++;

            Controller.views-= clickupgradebutton.GetComponent<PurchaseUpgrade>().cost;
        }

    }

}
