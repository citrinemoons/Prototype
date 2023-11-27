using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatMessage : MonoBehaviour
{
    private TextMeshProUGUI Textmesh;
    public Vector2 Size;
    public float Spacing;
    public string hexcolor;
    public Color ChatColor;
    // Start is called before the first frame update
    void Start()
    {
        Textmesh = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        Size = Textmesh.bounds.size;
        RectTransform rt = GetComponent<RectTransform>();
        Size.y = Size.y + Spacing;
        Size.x = Size.x + Spacing;
        rt.sizeDelta = Size;
    }
}
