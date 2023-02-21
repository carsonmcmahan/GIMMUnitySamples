using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell Object", menuName = "Inventory System/Spells/Destruction")]
public class DestructionSpells : Spells
{
    public void Awake()
    {
        type = SpellType.Destruction
    }
}
