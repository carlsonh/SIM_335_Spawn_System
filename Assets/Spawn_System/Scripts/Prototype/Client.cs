using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public Hamis m_Hamis;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;


    public Text m_UICounterDrone;
    private int m_IncrementorDrone = 0;

    public Text m_UICounterSniper;
    private int m_IncrementorSniper = 0;

    public Text m_UICounterHamis;
    private int m_IncrementorHamis = 0;

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

            m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.6f);
            m_UICounterDrone.text = "Drones: " + (m_IncrementorDrone + 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

            m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSniper * 1.2f);
            m_UICounterSniper.text = "Snipers: " + (m_IncrementorSniper + 1);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Hamis);

            m_Spawn.name = "Hamis_Friend_" + ++m_IncrementorHamis;
            m_UICounterHamis.text = "Friends: " + (m_IncrementorHamis + 1);
            m_Spawn.transform.position = new Vector3(Random.Range(-20f, 20f), -2f, Random.Range(-20f, 20f));


        }
    }
}
