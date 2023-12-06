using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Controller : MonoBehaviour
{
    public Slider TheSlider;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {




        if (UpgradesManager.UpgradeInstance.streambots >= 1)
        {
            TheSlider.gameObject.SetActive(true);
        }
        else
        {
            TheSlider.gameObject.SetActive(false);
        }
        TheSlider.maxValue = GameController.ControllerInstance.streambottimer;
        TheSlider.value = GameController.ControllerInstance.timer;
        


    }
}
