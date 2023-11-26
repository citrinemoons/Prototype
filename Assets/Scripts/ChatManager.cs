using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
    public List<GameObject> ChatList;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChatList.Count > 25)
        {
            ChatList.RemoveAt(0);
        }
    }
}
