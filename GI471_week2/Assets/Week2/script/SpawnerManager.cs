using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnerManager : MonoBehaviour
{
    public List<Spawner> spawnerList = new List<Spawner>();

    public static SpawnerManager instance;

    private void Start()
    {
        instance = this;
        Init();
    }

    private void Init()
    {
        Spawner[] spawnerArr = FindObjectsOfType<Spawner>();

        spawnerList = spawnerArr.ToList<Spawner>();

        //for(int i = 0; i < spawnerArr.Length; i++)
        //{
            //SpawnerList.Add(spawnerArr[i]);
        //}
        
    }

   public void Spawn()
    {
        foreach(Spawner Spawner in spawnerList)
        {
            Spawner.Spawn();
        }
    }
}
