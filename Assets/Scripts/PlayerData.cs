using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public int gold;
    public int skin_id;
    public string nickname;
    public bool isSolo;
    public PlayerData(Player player)
    {
        gold = player.gold;
        skin_id = player.skin_id;
        nickname = player.nickname;
        isSolo = player.isSolo;
    }
}