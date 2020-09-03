using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INPC
{
    void Speak();
}

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner
}
