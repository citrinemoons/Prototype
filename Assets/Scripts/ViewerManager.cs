using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ViewerManager : MonoBehaviour
{

    public Slider viewergenerateslider;
    public float sliderval;
    public float slidermulti;
    public TextMeshProUGUI viewercount;

    public GameObject ViewerPrefab;
    public List<GameObject> BadViewers;// = new List<GameObject>();
    public List<GameObject> GoodViewers;// = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        viewercount.text = $"{(BadViewers.Count + GoodViewers.Count)} Viewers";
        viewergenerateslider.value += Time.deltaTime;

        viewergenerateslider.maxValue = sliderval / (1 + (slidermulti * UpgradesManager.UpgradeInstance.viewergenerateupgrades));

        if (viewergenerateslider.value >= viewergenerateslider.maxValue)
        {
            SpawnViewer();
            viewergenerateslider.value = 0;
        }
        
        if (Input.GetKeyUp(KeyCode.V))
        {
            SpawnViewer();
        }
    }

    public GameObject GetGoodViewer()
    {
        return GoodViewers[Random.Range(0, GoodViewers.Count)];
    }

    public GameObject GetBadViewer()
    {
        return BadViewers[Random.Range(0, BadViewers.Count)];
    }
    public void SpawnViewer()
    {

        

        GameObject newviewer = Instantiate(ViewerPrefab, transform);
        if (newviewer.GetComponent<Viewer>().badperson)
        {
            BadViewers.Add(newviewer);
        }
        if (!newviewer.GetComponent<Viewer>().badperson)
        {
            GoodViewers.Add(newviewer);
        }
        

    }

}
