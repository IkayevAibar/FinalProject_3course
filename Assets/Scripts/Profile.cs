using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Profile : MonoBehaviour
{
    public GameObject cube;
    Player ctrl;
    PlayerData pd;
    public Text gold_text;
    public Text nick_text;
    public InputField iff;
    public Dropdown skin;
    // Start is called before the first frame update
    void Start()
    {
        ctrl = cube.GetComponent<Player>();
        pd = ctrl.LoadPlayer();
        if (pd != null)
        {
            iff.text = pd.nickname;
            gold_text.text = pd.gold.ToString();
            nick_text.text = pd.nickname;
            nick_text.gameObject.SetActive(true);
            skin.value = pd.skin_id;
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
