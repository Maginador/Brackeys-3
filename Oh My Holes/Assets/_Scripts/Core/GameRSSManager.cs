using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRSSManager : MonoBehaviour
{

    public static GameRSSManager instance;


    //RSS
    [SerializeField] int cash, holes, achievements; 
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    internal int GetCash()
    {
        return cash;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCash(int c)
    {
        cash += c;
    }


   
}
