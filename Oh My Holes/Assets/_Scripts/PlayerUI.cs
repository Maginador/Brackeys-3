using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    //Action
    [SerializeField] GameObject uiRoot;
    [SerializeField] Image actionBar;
    public delegate void ActionCallback();
    protected ActionCallback action;



    //TimeHandlers

    float totalTime, currentTime;
    float uiSize = 2;
    // Start is called before the first frame update
    void Start()
    {
        uiRoot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAction(float time, ActionCallback callback)
    {
       
        uiRoot.SetActive(true);
        totalTime = time;
        currentTime = time + Time.time;
        action += callback;
        StartCoroutine(Action());
    }

    IEnumerator Action()
    {
        while (currentTime > Time.time)
        {
            actionBar.rectTransform.localScale = new Vector3(1 - (currentTime - Time.time)/ totalTime, 1, 1);

            yield return new WaitForEndOfFrame();
        }
        if(action != null) action();
        action = null;
        uiRoot.SetActive(false);
    }
}
