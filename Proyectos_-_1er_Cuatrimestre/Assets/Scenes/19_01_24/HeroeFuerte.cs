using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroeFuerte : Heroe
{
    public float hability = 300f;

    public float getHability()
    {
        if (getQuest().id == 2)
        {
            return hability - 20.0f;
        }
        return hability;
    }
}
