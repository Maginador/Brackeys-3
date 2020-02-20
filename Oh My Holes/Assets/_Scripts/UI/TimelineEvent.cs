using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimelineEvent : MonoBehaviour
{

    //EventType

    public DataTypes.EventType timelineEvent;
    public TimelineEventScriptableObject[] EventsData;
    int currentEvent;
    //UI Elements
    [SerializeField] Image icon;

    // Start is called before the first frame update
    void Start()
    {
        ConfigureEvent();
    }

    private void ConfigureEvent()
    {
        icon.sprite = EventsData[currentEvent].sprite;
        icon.color = EventsData[currentEvent].filterColor;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerEvent()
    {
        //Temp event
        MonsterSpawner.instance.SpawnMonsters();
    }
    public void SetEvent(int e)
    {
        currentEvent = e;
    }
}
