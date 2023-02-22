using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardObject : InstrumentObject
{
    void Awake()
    {
        instrumentFamily = InstrumentFamily.Keyboard;
    }
}
