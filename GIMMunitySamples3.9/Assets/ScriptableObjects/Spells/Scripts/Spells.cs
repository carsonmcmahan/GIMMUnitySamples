using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpellType
{
    Alteration,
    Conjuration,
    Destruction,
    Illusion,
    Restoration
}
public abstract class Spells : ScriptableObject
{
    public string name;
    public SpellType type;
    //public string description;
    //public image img;
}
