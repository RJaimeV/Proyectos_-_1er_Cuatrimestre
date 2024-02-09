using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public string Name = "Ball";
    public float speed = 5f;
    public float AreaDetection = 2f;
    public Vector3 MousePosition;

    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Acceder a la posici�n del mouse
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MousePosition.z = 0f;
        }
        // Calcular direcci�n
        Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la direcci�n calculada
        transform.Translate(direction * speed * Time.deltaTime);
    }
    
}
