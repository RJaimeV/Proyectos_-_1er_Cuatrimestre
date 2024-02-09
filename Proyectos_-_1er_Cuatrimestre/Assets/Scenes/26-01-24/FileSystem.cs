using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public void CreateFile(string _name, string _extension)
    {
        string path = Application.dataPath + "/" + _name + _extension;

        if (!File.Exists(path))
        {
            string content = "Logic Date: " + System.DateTime.Now + "/n";
            FileSystem.AppendAllText(path, content);
        }
        else
        {
            Debug.LogWarning("Estás tratando de crear un archivo con el mismo nombre [" + _name + _extension + "], verifica");
        }
    }

    private void Start()
    {
        CreateFile("26 Ene 2024", ".save");
    }
}
