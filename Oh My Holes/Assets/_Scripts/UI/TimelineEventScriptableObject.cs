using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptableObjects/TimelineEvent", order = 1)]
public class TimelineEventScriptableObject : ScriptableObject
{
    public string EventName;
    public Color filterColor;
    public Sprite sprite;
    public GameObject eventObject;
    public GameObject globalEffect;
    public int duration;
}