using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    [SerializeField] GameObject hole;
    public static SpawnerSystem instance;

    //Hole
    public static List<GameObject> activeHoles, inactiveHoles;


    public void Start()
    {
        instance = this;
        activeHoles = new List<GameObject>();
        inactiveHoles = new List<GameObject>();

    }

    public void InstantiateHole(Vector3 pos)
    {
        if(inactiveHoles.Count > 0)
        {
            //use pool
        }
        else
        {
            var temp = Instantiate(hole, pos, Quaternion.identity);
            activeHoles.Add(temp);
        }


    }

}