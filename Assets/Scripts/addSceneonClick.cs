using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addSceneonClick : MonoBehaviour
{
    PlayerData pd;
    public Player pl;
    public void loadSolo()
    {
        pd = SaveSystem.LoadPlayer();

        pd.isSolo = true;

        SaveSystem.SavePlayer(new Player(pd));

        SceneManager.LoadScene(3);
    }
    public void loadMulti()
    {
        pd = SaveSystem.LoadPlayer();

        pd.isSolo = false;

        SaveSystem.SavePlayer(new Player(pd));

        SceneManager.LoadScene(3);
    }
}
