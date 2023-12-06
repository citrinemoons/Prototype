using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseUpgrade : MonoBehaviour
{
    public float cost;
    public bool IsPurchaseable;
    private Button Button;
    public TextMeshProUGUI CostText;
    public string WhatAmI;
    // Start is called before the first frame update
    void Start()
    {
        Button = GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        Button.interactable = IsPurchaseable;
        CostText.text = $"Cost : {Mathf.Round(cost)}";
        if (GameController.ControllerInstance.views >= cost)
        {
            IsPurchaseable = true;
        }
        else
        {
            IsPurchaseable = false;
        }
    }

    public void ClickUpgrade()
    {
        GameController.ControllerInstance.gameObject.GetComponent<UpgradesManager>().PurchaseUpgrade(WhatAmI);
    }
}
