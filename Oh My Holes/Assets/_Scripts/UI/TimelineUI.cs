using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimelineUI : MonoBehaviour
{

    [SerializeField] Image timeline;
    float baseHeight, baseWidth;
    private List<TimelineEvent> timelineEvents;
    [SerializeField] GameObject timelineEvent;

    // Start is called before the first frame update
    void Start()
    {
        baseHeight = timeline.rectTransform.rect.height;
        baseWidth = timeline.rectTransform.rect.width;
        timelineEvents = new List<TimelineEvent>();

        SeTimelineEvent(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (timelineEvents.Count < 0) return;

        UpdateTimelineEvents();
    }

    void UpdateTimelineEvents()
    {
        for(int i =0; i< timelineEvents.Count; i++)
        {
            timelineEvents[i].transform.localPosition = new Vector3(timelineEvents[i].transform.localPosition.x, timelineEvents[i].transform.localPosition.y + TimeManager.instance.delta, timelineEvents[i].transform.localPosition.z);
            if (timelineEvents[i].transform.localPosition.y > baseHeight / 2)
            {
                Destroy(timelineEvents[i].gameObject, .1f);
                timelineEvents[i].TriggerEvent();
                timelineEvents.Remove(timelineEvents[i]);
            }
        }
    }

    void SeTimelineEvent(float time)
    {

        var currentPosition = new Vector3 (baseWidth/2, -baseHeight/2,0);

        //TODO Add Pool
        var e = Instantiate(timelineEvent).GetComponent<TimelineEvent>();
        
        e.transform.parent = timeline.transform;
        e.GetComponent<TimelineEvent>().SetEvent(0);
        //e.GetComponent<RectTransform>().anchoredPosition = currentPosition;
        e.transform.localPosition = currentPosition;
        timelineEvents.Add(e);



    }
}
