using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        //Name = "Marco";

        Display();
    }


    // Update is called once per frame
    void Update()
    {
        move();
    }

    //Breif: This class is in charge of overriding the move method from
    //the base class "Animal"
    public override void move()
    {
        base.move();
    }

    int Suma(int x, int y)
    {
        return 0;
    }
}
