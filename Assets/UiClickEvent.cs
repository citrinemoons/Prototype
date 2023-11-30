using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiClickEvent : MonoBehaviour, IPointerClickHandler
{
    public GameObject BanDropDown;
    public static event BanMessage
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("YouRightClicked");

            GameObject BanMessage = Instantiate(BanDropDown, eventData.pointerCurrentRaycast.worldPosition, new Quaternion(0, 0, 0, 0));
            TheController.GetComponent<Controller>().CheckBan(BanMessage);
            GameObject ChatMessage = eventData.selectedObject as GameObject;
            BanMessage.GetComponent<BanMessage>().TheMessage = ChatMessage;
            Debug.Log(ChatMessage);
            
        }
        else if (eventData.button == PointerEventData.InputButton.Middle)
        {
            
        }

        else if (eventData.button == PointerEventData.InputButton.Right)
        {

            Debug.Log("Left click");
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
