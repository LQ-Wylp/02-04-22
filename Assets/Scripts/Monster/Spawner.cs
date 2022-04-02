using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> Monster;
    public List<Transform> SpawnPosition;
    public float IntervalSpawn;
    public int NbSpawnByInterval;
    private float Timer;

    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer > IntervalSpawn)
        {
            Spawn();
            Timer = 0;
        }
    }

    public void Spawn()
    {
        List<Transform> CopiePosition = new List<Transform>(SpawnPosition);

        for(int i = 0 ; i < NbSpawnByInterval; i++)
        {
            int rand = Random.Range(0, CopiePosition.Count);
            Transform PosSpawn = CopiePosition[rand];
            CopiePosition.RemoveAt(rand);

            
            int randMonster = Random.Range(0, Monster.Count); 
            GameObject InstantiateThis = Monster[randMonster];
            Instantiate(InstantiateThis, PosSpawn.position, Quaternion.identity);
        }

    }
}
