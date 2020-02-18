using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public static TimeManager instance;


    [SerializeField] float timeLeft, dayLenght; 
    [SerializeField] int dayCount; 
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        timeLeft = dayLenght;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            timeLeft = dayLenght;
            dayCount++;
        }
    }

    internal float GetTimeLeft()
    {
        return timeLeft;
    }

    internal int GetDay()
    {
        return dayCount;
    }
}
