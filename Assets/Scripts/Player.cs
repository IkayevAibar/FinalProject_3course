using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int gold = 8;
    public int skin_id = 0;
    public string nickname = "Player1";
    public bool isSolo = false;
    public Text goldText;
    public Text NeedMoney;
    public InputField input;
    public InputField code;
    public Dropdown dropdown;
    public Text _gold;
    public Text _nickname;
    public Text _skin_id;
    PlayerData pddd;
    public  Player( PlayerData pd)
    {
        gold = pd.gold;
        skin_id = pd.skin_id;
        nickname = pd.nickname;
        isSolo = pd.isSolo;
    }
    public void Accept()
    {
        Debug.Log(dropdown.value);
        pddd = SaveSystem.LoadPlayer();

        if (code.text == "MONEY")
        {
            gold = 999;
        }
        else { gold = int.Parse(_gold.text); }
        nickname = input.text==null?nickname: input.text;
        if (pddd != null) {
            if (dropdown.value == 1)
            {
                if (gold >= 100 && pddd.skin_id != 1)
                {
                    gold -= 100;
                    _gold.text = gold.ToString();
                    skin_id = dropdown.value;
                    NeedMoney.text = "Succesful";
                    dropdown.value = 1;
                }
                else
                {
                    NeedMoney.gameObject.SetActive(true);
                    if (pddd.gold < 100 && pddd.skin_id != 1)
                    {
                        NeedMoney.text = "Need 100 gold";
                    }
                    else
                        NeedMoney.text = "You already have this skin";

                    dropdown.value = 0;

                }
            }
            else if (dropdown.value == 2)
            {
                if (gold >= 500 && pddd.skin_id != 2)
                {
                    gold -= 500;
                    _gold.text = gold.ToString();
                    skin_id = dropdown.value;
                    NeedMoney.text = "Succesful";
                    dropdown.value = 2;
                }
                else
                {
                    NeedMoney.gameObject.SetActive(true);
                    if (pddd.gold < 500 && pddd.skin_id != 2)
                    {
                        NeedMoney.text = "Need 500 gold";
                    }
                    else
                        NeedMoney.text = "You already have this skin";

                    dropdown.value = 0;
                }
                dropdown.value = skin_id;
            }
            
        }

        SavePlayer();
    }
    public void DeleteProfile()
    {
        SaveSystem.DeletePlayer();
    }
    public void SetSolo(bool b)
    {
        isSolo = b;
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public PlayerData LoadPlayer()
    {
        PlayerData playerData = SaveSystem.LoadPlayer();
        
        return playerData;
    }
    
}
