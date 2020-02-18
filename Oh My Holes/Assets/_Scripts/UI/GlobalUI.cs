using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalUI : MonoBehaviour
{

    [SerializeField] Text cash, day, time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cash.text = GameRSSManager.instance.GetCash().ToString();
        day.text = TimeManager.instance.GetDay().ToString();
        time.text = TimeManager.instance.GetTimeLeft().ToString();
    }
}
