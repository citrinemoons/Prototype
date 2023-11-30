using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanMessage : MonoBehaviour
{

    public GameObject TheMessage;

    // Start is called before the first frame update
    public void OnDelete()
    {
        Destroy(TheMessage);
        Destroy(gameObject);
    }
    public void Cancel()
    {
        Destroy(gameObject);
    }
}
