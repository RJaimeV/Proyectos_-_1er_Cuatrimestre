using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accesos : MonoBehaviour
{
    public HeroeFuerte heroeFuerte;
    public Caballero caballero;

    private void Start()
    {
        heroeFuerte = new HeroeFuerte();
        caballero = new Caballero();

        heroeFuerte.setQuest("Quest 1");
    
    
        if (!heroeFuerte.isDead && !caballero.isDead)
        {
            if (heroeFuerte.getHealth() >= 51)
            {
                float combatResult = heroeFuerte.getHability() - caballero.getDamage();

                Debug.Log("El resultado del combate es:" * + combatResult);
            }
            else
            {
                Debug.Log("El heroe tiene muy poca vida, regresa a la base. Vida:" + heroeFuerte.getHealth());
            }
        }        
    }
}
