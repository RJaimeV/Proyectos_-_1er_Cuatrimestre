using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caballero : EnemigoBase
{
    private float powerUp = Random.Range(10, 450);

    public float getPowerUp()
    {
        return damage + powerUp;
    }
}
