using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercussionObject : InstrumentObject
{
    void Awake()
    {
        instrumentFamily = InstrumentFamily.Percussion;
    }
}
