using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringObject : InstrumentObject
{
    public int numStrings;
    //public int[] strings = new int[4]; 
    Dictionary<char, float> stringFreq = new Dictionary<char, float>();
    void Awake()
    {
        instrumentFamily = InstrumentFamily.Strings;
    }


}
