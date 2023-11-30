using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Controller : MonoBehaviour
{
    public UpgradesManager TheUpgradeManager;
    public Controller TimerController;
    public Slider TheSlider;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {




        if (TheUpgradeManager.streambots >= 1)
        {
            TheSlider.gameObject.SetActive(true);
        }
        else
        {
            TheSlider.gameObject.SetActive(false);
        }
        TheSlider.maxValue = TimerController.streambottimer;
        TheSlider.value = TimerController.timer;
        


    }
}
