using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    public int hitpoints;
    public int attack;
    public int defense;
    public int speed;

    public Stat(int hp, int atk, int def, int spd)
    {
        hitpoints = hp;
        attack = atk;
        defense = def;
        speed = spd;
    }
}
