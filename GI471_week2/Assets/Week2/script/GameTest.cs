using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTest : MonoBehaviour
{
    //public SpawnerManager spawnerManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //SpawnerManager.instance.Spawn();
            EventManager.instance.TriggerEvent("Spawn");
        }
    }
}
