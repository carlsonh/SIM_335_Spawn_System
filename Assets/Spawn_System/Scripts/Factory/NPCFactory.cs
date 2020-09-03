using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{

    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Farmer:
                INPC beggar = new Beggar();
                return beggar;

            case NPCType.Beggar:
                INPC farmer = new Farmer();
                return farmer;

            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
        }
        return null;
    }
}
