using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InstrumentFamily
{
    Percussion,
    Woodwinds,
    Brass,
    Strings,
    Keyboard
}
public class InstrumentObject : ScriptableObject
{
    public InstrumentFamily instrumentFamily;

}
