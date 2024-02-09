using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    /*
     * GAMELOOP
     * Int(); o Start();
     * Update
     * Render()
     * Destroy
     */
    
    [SerializeField]
    protected string Name = "Enemy";
    [SerializeField]
    protected int Health = 100;
    [SerializeField]
    protected List<string> Loot;

    /// <summary>
    /// This method is in change of intitializing the nombers of the class
    /// </summary>

    public virtual void Init()
    {
        Loot = new List<string>();
    }
    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    public virtual List<string> GetLoot()
    {
        return Loot;
    }
    public virtual int GetHealth()
    {
        return Health;
    }
}
