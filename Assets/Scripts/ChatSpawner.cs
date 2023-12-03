using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChatSpawner : MonoBehaviour
{
    public string StreamerName;
    public string[] Usernames;
    public GameObject MessagePrefab;
    public Transform Parent;
    private TMP_InputField InputField;

    public ChatManager ChatManager;

    public string[] Nouns;
    public string[] Verbs;
    public string[] Adjectives;
    public string[] Interjection;
    public string[] Pronouns;
    public string[] Prepositions;
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

        if (Input.GetKeyDown(KeyCode.R))
        {
            //Debug.Log("Random Simplemessgae");
            int sentencetype = Random.Range(0, 3);
            if(sentencetype == 0)
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
    }


    public void SendStreamMessageEvent(string chat)
    {
        if (string.IsNullOrEmpty(chat))
        {
            return;
        }
        GameObject MessageOBJ = Instantiate(MessagePrefab, Parent);
        string chatmessage = $"<b><color=#ff0000ff>{StreamerName}</b>:</color>{chat}";
        MessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = chatmessage;
        InputField.text = string.Empty;
        ChatManager.ChatList.Add(MessageOBJ);
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
            Color32 namecolor = Random.ColorHSV(0, 1, 0.7f, 1, 0.8f, 1);
            string RancomChatMessgaeString = $"<b><color=#{UnityEngine.ColorUtility.ToHtmlStringRGB(namecolor)}>{Usernames[Random.Range(0,Usernames.Length)]}</b>:</color>{randstring}";
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
            Color32 namecolor = Random.ColorHSV(0, 1, 0.7f, 1, 0.8f, 1);
            string RancomChatMessgaeString = $"<b><color=#{UnityEngine.ColorUtility.ToHtmlStringRGB(namecolor)}>{Usernames[Random.Range(0, Usernames.Length)]}</b>:</color>{randstring}";
            RandomMessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = RancomChatMessgaeString;

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
            Color32 namecolor = Random.ColorHSV(0, 1, 0.7f, 1, 0.8f, 1);
            string RancomChatMessgaeString = $"<b><color=#{UnityEngine.ColorUtility.ToHtmlStringRGB(namecolor)}>{Usernames[Random.Range(0, Usernames.Length)]}</b>:</color>{randstring}";
            RandomMessageOBJ.GetComponentInChildren<TextMeshProUGUI>().text = RancomChatMessgaeString;

            ChatManager.ChatList.Add(RandomMessageOBJ);
        }
    }
}
