using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using BayatGames.SaveGameFree;

public static class SaveSystem
{

    public static int version=0;
    public static string auxVersion = "";

    public static void SaveGameplay(Vector2 mov, float DevelopsSpeed1, string identifier1)
    {
        auxVersion = SaveGame.Load<string>("LastVersion.txt", "version");

        if (auxVersion == "")
        {
            version = 0;
            auxVersion = ""+version;
        }

        version = int.Parse(auxVersion);
        version++;

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameplayData_version" + version + ".gd";

        Debug.Log("El numero de partida golbal es: "+version);
        Debug.Log(path);

        FileStream stream = new FileStream(path , FileMode.Create);

        GameData data = new GameData(mov, DevelopsSpeed1, identifier1);

        formatter.Serialize(stream, data);

        SaveGame.Save<string>("LastVersion.txt", ""+version); //identificador

        stream.Close();

    }

    public static GameData LoadGameplay(int i)
    {

        string path = Application.persistentDataPath + "/gameplayData_version" + i + ".gd";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
            
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
