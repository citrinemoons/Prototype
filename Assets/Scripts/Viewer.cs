using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Viewer : MonoBehaviour
{
    public delegate void SpawnNewMessage();
    public static event SpawnNewMessage OnSpawnNewMessage;

    public string[] GoodUsernames;
    public string[] BadUsernames;

    public Color ViewerColor;
    public string ViewerName;
    public bool badperson;

    public float timer;
    public float HowOftenIWantToChat;

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
            ViewerName = GoodUsernames[Random.Range(0, GoodUsernames.Length)];
        }
        gameObject.name = ViewerName;
        Color32 namecolor = Random.ColorHSV(0, 1, 0.7f, 1, 0.8f, 1);
        ViewerColor = namecolor;
        HowOftenIWantToChat = Random.Range(3f, 20f);

    }

    public void Update()
    {

        timer += Time.deltaTime;
        if (timer > HowOftenIWantToChat)
        {
            OnSpawnNewMessage.Invoke();
            timer = 0;
        }


    }
}
