using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;

    public void SpawnVillagers()
    {


        //Have factory manufacture the villagers

        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

        m_Farmer.Speak();
        m_Beggar.Speak();
        m_Shopowner.Speak();
    }
}
