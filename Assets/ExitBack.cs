using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitBack : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnHeckOff()
    {
        SceneManager.LoadScene(0);
    }
}
