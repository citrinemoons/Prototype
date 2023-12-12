using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ChatSpawner : MonoBehaviour
{
    

    public ViewerManager ViewerManager;
    public GameObject MessagePrefab;
    public Transform Parent;
    private TMP_InputField InputField;

    public Scrollbar DaScrollbar;

    public ChatManager ChatManager;

    public string[] Nouns;
    public string[] Verbs;
    public string[] Adjectives;
    public string[] Interjection;
    public string[] Pronouns;
    public string[] Prepositions;

    public bool debug;
    // Start is called before the first frame update
    void Start()
    {
        InputField = GetComponentInChildren <TMP_InputField>();
    }

    public void RandomMessageSystem()
    {

        

    }
    private void OnEnable() => Viewer.OnSpawnNewMessage += GenerateType;
    private void OnDisable() => Viewer.OnSpawnNewMessage -= GenerateType;

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SendStreamMessageEvent(InputField.text);
            DaScrollbar.value = 0;
        }
        if (debug)
        {
            if (Input.GetKeyUp(KeyCode.B))
            {
                RandomChatMessage("bad", 0);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Debug.Log("Random Simplemessgae");
                

            }
        }
        
    }


    public void SendStreamMessageEvent(string chat)
    {
        if (string.IsNullOrEmpty(chat))
        {

        }
        else
        {
            GameObject MessageOBJ = Instantiate(MessagePrefab, Parent);
            string chatmessage = $"<b><color=#ff0000ff>{GameController.ControllerInstance.StreamerName}</b>:</color>{chat}";
            MessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = chatmessage;
            InputField.text = string.Empty;
            ChatManager.ChatList.Add(MessageOBJ);
        }
       
    }

    private void GenerateType()
    {
        int sentencetype = Random.Range(0, 3);
        if (sentencetype == 0)
        {
            RandomChatMessage("simple", Random.Range(0, 3));
        }
        if (sentencetype == 1)
        {
            RandomChatMessage("complex", Random.Range(0, 3));
        }
        if (sentencetype == 2)
        {
            RandomChatMessage("hype", Random.Range(0, 3));
        }
    }

    public void RandomChatMessage(string type, int rand)
    {


        if (type == "simple")
        {
            Debug.Log(type+rand);
            string randstring = string.Empty;
            switch (rand)
            {
                case 2:
                    randstring = $"I heard {Pronouns[Random.Range(0, Pronouns.Length)]} ate {Nouns[Random.Range(0, Nouns.Length)]}";
                    break;
                case 1:
                    randstring = $"Sometimes I Dream about {Nouns[Random.Range(0, Nouns.Length)]}!";
                    break;
                case 0:
                    randstring = $"I {Verbs[Random.Range(0, Verbs.Length)]} {Adjectives[Random.Range(0, Adjectives.Length)]} {Nouns[Random.Range(0, Nouns.Length)]}";
                    break;


            }
            GameObject RandomMessageOBJ = Instantiate(MessagePrefab, Parent);
            GameObject ourviewer = ViewerManager.GetGoodViewer();
            string RancomChatMessgaeString = $"<b><color=#{ourviewer.GetComponent<Viewer>().ViewerColor.ToHexString()}>{ourviewer.name}</b>:</color>{randstring}";
            RandomMessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = RancomChatMessgaeString;
            ChatManager.ChatList.Add(RandomMessageOBJ);
        }

        if (type == "complex")
        {
            string randstring = string.Empty;
            switch (rand)
            {
                case 2:
                    randstring = $"Did {Pronouns[Random.Range(0, Pronouns.Length)]} know that {Nouns[Random.Range(0, Nouns.Length)]} can sometimes be found {Prepositions[Random.Range(0,Prepositions.Length)]} {Nouns[Random.Range(0, Nouns.Length)]}, I know it's CRAZY!";
                    break;
                case 1:
                    randstring = $"{Prepositions[Random.Range(0,Prepositions.Length)]}, I was looking at the stream and I Just noticed that my {Nouns[Random.Range(0, Nouns.Length)]} suddenly learnt how to {Verbs[Random.Range(0, Verbs.Length)]}. I would never realise that it could do that, kinda {Adjectives[Random.Range(0, Adjectives.Length)]}";
                    break;
                case 0:
                    randstring = $"So a {Nouns[Random.Range(0, Nouns.Length)]},a {Nouns[Random.Range(0, Nouns.Length)]} and a {Nouns[Random.Range(0, Nouns.Length)]} walk into a bar and order a drink. Then out of the blue!, they all pulled out a {Nouns[Random.Range(0, Nouns.Length)]}. It was crazy, thought I was is in some video game or something.";
                    break;


            }
            GameObject RandomMessageOBJ = Instantiate(MessagePrefab, Parent);
            GameObject ourviewer = ViewerManager.GetGoodViewer();
            string RancomChatMessgaeString = $"<b><color=#{ourviewer.GetComponent<Viewer>().ViewerColor.ToHexString()}>{ourviewer.name}</b>:</color>{randstring}";
            RandomMessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = RancomChatMessgaeString;
            ChatManager.ChatList.Add(RandomMessageOBJ);

            ChatManager.ChatList.Add(RandomMessageOBJ);
        }

        if (type == "hype")
        {
            string randstring = string.Empty;
            switch (rand)
            {
                case 2:
                    randstring = $"POGGGG!!!";
                    break;
                case 1:
                    randstring = $"Thats CRAZY! can we get some <sprite=1> in chat~!";
                    break;
                case 0:
                    randstring = $"<sprite=3><sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3> <sprite=3>  ";
                    break;


            }
            GameObject RandomMessageOBJ = Instantiate(MessagePrefab, Parent);
            GameObject ourviewer = ViewerManager.GetGoodViewer();
            string RancomChatMessgaeString = $"<b><color=#{ourviewer.GetComponent<Viewer>().ViewerColor.ToHexString()}>{ourviewer.name}</b>:</color>{randstring}";
            RandomMessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = RancomChatMessgaeString;
            ChatManager.ChatList.Add(RandomMessageOBJ);
        }
        if (type == "bad")
        {
            string randstring = string.Empty;
            switch (rand)
            {

                case 2:
                    randstring = $"L Steamer";
                    break;
                case 1:
                    randstring = $"Daum I didnt expect to be bored by this stream,Go do something better lmao";
                    break;
                case 0:
                    randstring = $"Fuck off";
                    break;
            }
            GameObject RandomMessageOBJ = Instantiate(MessagePrefab, Parent);
            GameObject ourviewer = ViewerManager.GetBadViewer();
            string RancomChatMessgaeString = $"<b><color=#{ourviewer.GetComponent<Viewer>().ViewerColor.ToHexString()}>{ourviewer.name}</b>:</color>{randstring}";
            RandomMessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = RancomChatMessgaeString;
            ChatManager.ChatList.Add(RandomMessageOBJ);
            RandomMessageOBJ.GetComponent<ChatMessage>().BadMessage = true;


        }
    }
}
