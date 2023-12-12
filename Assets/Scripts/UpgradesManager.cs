using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{

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
    [Header("Viewer Upgrades")]
    public int viewergenerateupgrades;
    public float viewergenerateupgradescost;
    public float viewergenerateupgradescostmulti;
    public GameObject viewergeneratebutton;
    public TextMeshProUGUI viewergenerateVal;
    [Header("Totals")]
    public float totalmultiplier;
   
    private static UpgradesManager Upgradeinstance;

    public static UpgradesManager UpgradeInstance

    {
        get { return Upgradeinstance; }
        set
        {
            if (Upgradeinstance == null)
            {
                Upgradeinstance = value;
            }
            else
            {
                Destroy(value.gameObject);
            }
        }
    }
    private void Awake()
    {
        UpgradeInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        StreambotVal.text = $"Amount : {streambots}";
        ClickUpgradeVal.text = $"Amount : {clickupgrades}";
        viewergenerateVal.text = $"Upgrades : {viewergenerateupgrades}";

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

        GameController.ControllerInstance.streambottimer = streambotcosttimerbase / (1 + (streambotmultiplyer * (streambots-1)));


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
        float viewerupgradef = viewergenerateupgrades;
        if (viewerupgradef > 0 )
        {
            float multipiedviewcost = Mathf.Pow((viewergenerateupgradescostmulti), viewergenerateupgrades);
            float viewupgradescosttemptemp = multipiedviewcost * viewergenerateupgradescost;
            viewergeneratebutton.GetComponent<PurchaseUpgrade>().cost = viewupgradescosttemptemp;
        }
        else
        {
            viewergeneratebutton.GetComponent<PurchaseUpgrade>().cost = viewergenerateupgradescost;
        }


    }

    public void PurchaseUpgrade(string Upgrade)
    {

        if (Upgrade == "Bot")
        {
            streambots++;
            //Controller.timer = 0f;
            GameController.ControllerInstance.views -= StreamBotButton.GetComponent<PurchaseUpgrade>().cost;
            totalmultiplier++;
        }

        if (Upgrade == "Click")
        {
            clickupgrades++;

            GameController.ControllerInstance.views-= clickupgradebutton.GetComponent<PurchaseUpgrade>().cost;
            totalmultiplier++;
        }
        if (Upgrade == "Viewer")
        {
            viewergenerateupgrades++;
            GameController.ControllerInstance.views -= viewergeneratebutton.GetComponent<PurchaseUpgrade>().cost;
            totalmultiplier++;
        }
    }

}
