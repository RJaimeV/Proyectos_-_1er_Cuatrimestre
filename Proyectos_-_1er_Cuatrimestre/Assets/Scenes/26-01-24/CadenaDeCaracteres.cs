using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaDeCaracteres : MonoBehaviour
{
    public GameObject prefab;
    public string data = "x:2, y:5, z:8";
    public Vector3 pos;


    void Start()
    {

        string[] components = data.Split(',');

        foreach (string component in components)
        {

            string trimmedComponent = component.Trim();


            if (trimmedComponent.Contains("x"))
            {
                int x = (int)char.GetNumericValue(trimmedComponent[2]);
                pos = new Vector3(x, pos.y, pos.z);
            }
            else if (trimmedComponent.Contains("y"))
            {
                int y = (int)char.GetNumericValue(trimmedComponent[2]);
                pos = new Vector3(pos.x, y, pos.z);
            }
            else if (trimmedComponent.Contains("z"))
            {
                int z = (int)char.GetNumericValue(trimmedComponent[2]);
                pos = new Vector3(pos.x, pos.y, z);
            }
        }
        FileSystem.Instance.CreateFile("Posiciones", ".save", position);

        Instantiate(prefab, pos, Quaternion.identity);
    }
}
