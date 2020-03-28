using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem { 

    public static void SavePlayer(Player player)
    {
        BinaryFormatter frmt = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.data";
        FileStream fs = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        frmt.Serialize(fs, data);
        fs.Close();
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.data";

        if (File.Exists(path))
        {
            BinaryFormatter frmt = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);

            PlayerData pd = (PlayerData)frmt.Deserialize(fs);
            fs.Close();

            return pd;
        }
        else
        {
            Debug.LogError("Can't find a file in " + path);
            return null;
        }
    }
    public static void DeletePlayer()
    {
        string path = Application.persistentDataPath + "/player.data";

        if (File.Exists(path))
        {
            File.Delete(path);
            return;
        }
        else
        {
            Debug.LogError("Can't find a file in " + path);
            return;
        }
    }
}
