using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlipFlop : MonoBehaviour
{

    private Animator DaAnimator;
    public float animationtime;
    public float speed;
    // Start is called before the first frame update
    private void Start()
    {
        DaAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        DaAnimator.SetFloat("DanceFloat", animationtime);
    }
    public void Driver()
    {

        if (animationtime == 0)
        {
            animationtime = Mathf.Lerp(0, 1, speed);
        }
        else
        {
            animationtime = Mathf.Lerp(1, 0, speed);
        }

        AudioSource clip = GetComponent<AudioSource>();
        clip.Play();
    }


}
