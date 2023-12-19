using UnityEngine;

public class SaveGame : MonoBehaviour
{
    private GameController gameController;

    private void Awake()
    {
        gameController = GetComponent<GameController>();
        LoadGameData();
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            SaveGameData(); //saves the variables when player pauses game
        }
    }

    private void OnApplicationQuit()
    {
        SaveGameData();  //saves the variables if player quits the game
    }

    public void SaveGameData()
    {
      PlayerPrefs.SetString("StreamerName", gameController.StreamerName);
      PlayerPrefs.SetString("views", gameController.views.ToString());
      PlayerPrefs.Save();
      Debug.Log("saved the game");
    }

    public void LoadGameData()
    {
       if (PlayerPrefs.HasKey("StreamerName"))
        {
            gameController.StreamerName = PlayerPrefs.GetString("StreamerName");
        }
       if (PlayerPrefs.HasKey("views"))
        {
            double.TryParse(PlayerPrefs.GetString("views"), out gameController.views);
        }
        Debug.Log("save game loaded");
    }
}
