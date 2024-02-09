using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Contenedor de toda la logica de nuestro objeto
public class Tema1 : MonoBehaviour
{
    //VARIABLES GLOBALES   
    //Variables: Contenedor de informacion
    public int edad = 22;

    void Start()
    {

        // VARIABLES LOCALES
        int resultado = suma(5, 5);

        Debug.Log("El resultado es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void walk(/* parametros */)
    {

    }
    // Función
    int suma (int x, int y)
    {
        return x = y;
    }
}
