using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
// loads level one
  public void LevelOne()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

//loads level two
 public void LevelTwo()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
  }

//exit game
 public void Quit()
 {
    Application.Quit();
    Debug.Log("Quit Game Successfully");
 }

}
