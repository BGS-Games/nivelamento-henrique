using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDictionary
{
    private readonly Dictionary<string, int> powerDic = new();

    public string Type {get;} 

    public PowerDictionary(string type)
    {
        Type = type;
    }

    public void SetValue (string cardName, int value)
    {
        powerDic[cardName] = value; 
    }

    public int GetValue(string cardName)
    {
        if (powerDic.ContainsKey(cardName)) 
        {
            return powerDic[cardName];
        }

        return -1; 
    }

    public Dictionary<string, int> GetPowerDic() { return powerDic; }
}
