using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public static FileSystem Instance;

    private void Awake()
    {
        if (Instance == null) 
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }
    public void CreateFile(string _name, string _extension)
    {
        string path = Application.dataPath + "/" + _name + _extension;

        if (!File.Exists(path))
        {
            string content = "Logic Date: " + System.DateTime.Now + "/n";
            File.AppendAllText(path, content);
        }
        else
        {
            Debug.LogWarning("Est�s tratando de crear un archivo con el mismo nombre [" + _name + _extension + "], verifica");
        }
    }

    public void CreateFile(string _name, string _extension, Vector3 vec)
    {
        string path = Application.dataPath + "/" + _name + _extension;

        if (!File.Exists(path))
        {
            string content = vec.ToString() + "/n";
            Debug.Log("Se almaceno la informacion" + content);
            File.AppendAllText(path, content);
        }
        else
        {
            Debug.LogWarning("Est�s tratando de crear un archivo con el mismo nombre [" + _name + _extension + "], verifica");
        }
    }

    private void Start()
    {
        CreateFile("26 Ene 2024", ".save");
    }
}
