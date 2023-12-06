using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ViewerManager : MonoBehaviour
{
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
