using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "TotemScriptableObject", menuName = "ScriptableObjects/Totem")]
public class Totems : ScriptableObject
{
    public enum Direction {North, East, South, West};

    public string name;
    [TextArea(15,20)]
    public string motto;
    public int level;
    //public GameObject prefab;
    public int hitpoints;
    public int attack;
    public int defense;
    public int speed;
}
