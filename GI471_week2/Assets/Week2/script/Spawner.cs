using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject monster;

    public UnityEvent OnSpawn;

    private void OnEnable()
    {
        EventManager.instance.StarListening("Spawn", Spawn);
    }

    private void OnDisable()
    {
        EventManager.instance.StarListening("Spawn", Spawn);
    }
    //private void Start()
    //{
        //EventManager.instance.StarListening("Spawn", Spawn);
    //}

    public void Spawn()
    {
        Instantiate(monster, this.transform.position, this.transform.rotation);
    }
}
