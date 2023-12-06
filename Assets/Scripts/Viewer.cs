using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewer : MonoBehaviour
{
    public string[] GoodUsernames;
    public string[] BadUsernames;

    public Color ViewerColor;
    public string ViewerName;
    public bool badperson;

    // Start is called before the first frame update
    private void Awake()
    {
        badperson = Random.value < 0.15f;
        if (badperson)
        {
            ViewerName = BadUsernames[Random.Range(0, BadUsernames.Length)];
        }
        else
        {
            ViewerName = GoodUsernames[Random.Range(0,GoodUsernames.Length)];
        }
        gameObject.name = ViewerName;
        Color32 namecolor = Random.ColorHSV(0, 1, 0.7f, 1, 0.8f, 1);
        ViewerColor = namecolor;

    }
}
