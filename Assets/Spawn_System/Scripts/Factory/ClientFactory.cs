using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientFactory : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
