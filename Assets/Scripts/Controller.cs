using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class GameController : MonoBehaviour
{
    public TMP_Text viewsText;
    public GameObject SingleMessageBan;
    public Button StreamButton;

    public double views;

    public string StreamerName;

    public float timer;
    public float streambottimer;

    public bool IsLive;

    private static GameController Controllerinstance;

    public static GameController ControllerInstance

    {
        get { return Controllerinstance; }
        set
        {
            if (Controllerinstance == null)
            {
                Controllerinstance = value;
            }
            else
            {
                Destroy(value.gameObject);
            }
        }
    }
    private void Awake()
    {
        ControllerInstance = this;
    }
    private void OnEnable() => BanMessage.OnBanMessageCheck += AddPointsForBan;
    private void OnDisable() => BanMessage.OnBanMessageCheck += AddPointsForBan;
    public void Update()
    {
        viewsText.text = $"{Mathf.Round((float)views)} StreamPoints";
        ClickAutomation();
    }

    public void GenerateViews()
    {
        Debug.Log("you have earned points");
        if (IsLive)
        {
            views = (2 * (UpgradesManager.UpgradeInstance.clickupgrades * 2) + 1) + views;
        }
        else
        {
            views = (1 * UpgradesManager.UpgradeInstance.clickupgrades + 1) + views;
        }

    }

    public void ClickAutomation()
    {
        timer += Time.deltaTime;

        if (UpgradesManager.UpgradeInstance.streambots >= 1)
        {
            if (timer > streambottimer)
            {
                GenerateViews();
                timer = 0f;
            }
        }



    }

    public void AddPointsForBan()
    {
        views += 100;
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
