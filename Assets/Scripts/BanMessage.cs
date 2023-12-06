using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanMessage : MonoBehaviour
{
    public delegate void BanMessageCheck();
    public static event BanMessageCheck OnBanMessageCheck;

    public GameObject TheMessage;

    // Start is called before the first frame update
    public void OnDelete()
    {
        CheckIfBan();
        Destroy(TheMessage);
        Destroy(gameObject);
    }
    public void Cancel()
    {
        Destroy(gameObject);
    }
    public void CheckIfBan()
    {
        if (TheMessage.GetComponent<ChatMessage>().BadMessage)
        {
            Debug.Log("Checked Ban");
            OnBanMessageCheck.Invoke();
        }
        else
        {

        }
    }


}
