using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveLoadSystemData
{
    public static void SaveData<T>(T data, string path, string fileName)
    {
        //Crear variable archivo
        string fullPath = Application.dataPath + "/" + path;
        //bool para verificar archivo
        bool checkFolderExit = Directory.Exists(fullPath);
        if (checkFolderExit == false)
        {
            //Crea la carpeta si no existe
            Directory.CreateDirectory(fullPath);
        }
        //crea el archivo en Json
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(fullPath + fileName + ".json", json);
        //Mensaje para comprobar que todo esta ok
        Debug.Log("Save data ok. " + fullPath);
    }

    public static T LoadData<T>(string path, string fileName)
    {
        //armamos la dirección del archivo
        string fullPath = Application.dataPath + "/" + path + fileName + ".json";
        if (File.Exists(fullPath))
        {
            //Leemos el Texto
            string textJson = File.ReadAllText(fullPath);
            //De Json a un Obj que Unity entiende
            var obj = JsonUtility.FromJson<T>(textJson);
            Debug.Log("Data Cargado. ");
            return obj;
        }
        else
        {
            //aviso que no encontró el archivo
            Debug.Log("Not Data. ");
            return default;
        }
    }

}
