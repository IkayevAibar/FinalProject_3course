using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] Spawners;
    public GameObject cylinder;
    public GameObject cylinders;
    public GameObject sphere;
    int a, b;
    ArrayList list;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        b = 3;
        for(int i = 0;i<Spawners.Length/3;i++)
            Invoke("Spawn", 0.1f );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        
        int spawnIndex = Random.Range(a, b);
        Object clone = 
        (Instantiate(cylinder, Spawners[spawnIndex].position, Spawners[spawnIndex].rotation) as GameObject).transform.parent = cylinders.transform  ;
        int spawnIndex2 = Random.Range(a, b);
        if (spawnIndex != spawnIndex2) { 
            Instantiate(sphere, Spawners[spawnIndex2].position, Spawners[spawnIndex2].rotation);
        }
        a = a + 3;
        b = b + 3;
    }
}
