using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseUpgrade : MonoBehaviour
{
    public GameObject GameManager;
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
        if (GameManager.GetComponent<Controller>().views >= cost)
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
        GameManager.GetComponent<UpgradesManager>().PurchaseUpgrade(WhatAmI);
    }
}
