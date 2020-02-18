using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public static MonsterSpawner instance;
    List<HoleController> holesList;
    [SerializeField] GameObject[] monsters;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        holesList = new List<HoleController>();
    }

    // Update is called once per frame
    void Update()
    {
        //TestSpawn TODO add timeline event 
        if (Input.GetKeyDown(KeyCode.G))
        {
            SpawnMonsters();
        }
    }

    public void SpawnMonsters()
    {
        for(int i =0; i<holesList.Count; i++)
        {
            //Choose Monster 
            int monster = SelectMonsterToSpawn();
            //Do spawn for each hole
            //TODO : Add Pool
            Instantiate(monsters[0], holesList[i].transform.position, Quaternion.identity);
        }
    }

    private int SelectMonsterToSpawn()
    {
        //Simple random
        var rand = UnityEngine.Random.Range(0, monsters.Length);
        return rand;

        //TODO Smart selection
    }

    public void RegisterHole(HoleController hole)
    {
        holesList.Add(hole);
    }

    public void UnregisterHole(HoleController hole)
    {
        holesList.Remove(hole);
    }
}
