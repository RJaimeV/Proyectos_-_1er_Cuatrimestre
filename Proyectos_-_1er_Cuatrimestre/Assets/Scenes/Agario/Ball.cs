using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : BallBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    
    public override void move()
    {
        // Acceder a la posici�n del mouse
         MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);          
         MousePosition.z = 0f;        
        // Calcular direcci�n
         Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la direcci�n calculada
         transform.Translate(direction * speed * Time.deltaTime);
    }
}
