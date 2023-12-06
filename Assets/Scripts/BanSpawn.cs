using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BanSpawn : MonoBehaviour, IPointerClickHandler
{
    public GameObject BanDropDown;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
          
        }
        else if (eventData.button == PointerEventData.InputButton.Middle)
        {
            
        }

        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (BanCheckOne._instance != null)
            {
                GameObject Oldmessage = BanCheckOne._instance.gameObject;
                Destroy(Oldmessage);
            }
            GameObject BanMessage = Instantiate(BanDropDown, eventData.pointerCurrentRaycast.worldPosition, new Quaternion(0, 0, 0, 0));
            GameObject ChatMessage = eventData.pointerPress;
            Debug.Log(ChatMessage);
            BanMessage.GetComponent<BanMessage>().TheMessage = ChatMessage;
        
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
