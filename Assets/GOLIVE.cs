using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOLIVE : MonoBehaviour
{
    public bool islive;
    public Slider liveslider;
    public Button Golive;
    public float timer;
    public float timerbase;
    public float cooldowntimer;
    public float temptime;
    public bool cooldownbool;
    // Start is called before the first frame update
    private void Start()
    {
        liveslider.maxValue = timerbase;
    }
    // Update is called once per frame
    void Update()
    {

        GameController.ControllerInstance.IsLive = islive;

        

        if (islive)
        {
            //liveslider.value = liveslider.maxValue;
            timer -= Time.deltaTime;
            if (timer > 0)
            {
                Golive.interactable = false;
                islive = true;
                liveslider.value = timer;
            }
            else
            {
                islive = false;
                cooldownbool = true;
            } 
        }
        if (cooldownbool)
        {
            temptime += Time.deltaTime;
            if (temptime < cooldowntimer)
            {
                islive = false;
                Golive.interactable = false;
                
            }
            else
            {
                temptime = 0;
                Golive.interactable = true;
                cooldownbool = false;
            }
        }
    }

    public void goinglive()
    {
        islive = true;
        timer = timerbase;
     
    }
}
