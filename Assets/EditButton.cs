using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EditButton : MonoBehaviour
{   PlayerData pd;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        pd = SaveSystem.LoadPlayer();
        if (pd != null)
        {
            text.text += ": " + pd.nickname.ToUpper();

        }
        else
        {
            text.text = "Profile";
        }
    }
    public void LoadProfile()
    {
        SceneManager.LoadScene(1);
    }
}
