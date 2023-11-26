using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    public string[] Usernames;
    public GameObject MessagePrefab;
    public Transform Parent;
    public TMP_InputField InputField;

    public ChatManager ChatManager;

    // Start is called before the first frame update
    void Start()
    {
        InputField = GetComponentInChildren <TMP_InputField>();
    }




    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Return))
        {
            SendStreamMessageEvent(InputField.text);
        }


    }


    public void SendStreamMessageEvent(string chat)
    {
        GameObject MessageOBJ = Instantiate(MessagePrefab, Parent);
        string chatmessage = $"<b><color=#ff0000ff>{Usernames[Random.Range(0, Usernames.Length)]}</b>:</color>{chat}";
        MessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = chatmessage;

        ChatManager.ChatList.Add(MessageOBJ);
    }


}
