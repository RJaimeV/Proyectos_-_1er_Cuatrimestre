using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaBase : MonoBehaviour
{
    public Sprite icon;
    public Rarity rarity;
    public Enchantment enchantment;
    public string name;
    public int damage;
    public int durability;

    public void Start()
    {
        GetComponent<SpriteRenderer>().sprite = icon;
    }
    public virtual int GetAttack()
    {
        return 0;
    }
}
public enum Rarity
{
    BASE = 0,
    WOOD = 1,
    STONE = 2,
    IRON = 3,
    GOLD = 4,
    DIAMOND = 5,
    NEDERITHE = 6
}
public enum Enchantment
{
    NONE = 0,
    FIRE = 1,
    THROE = 2,
}

