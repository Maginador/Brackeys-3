using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextUI : MonoBehaviour
{
    //UI Elements
    [SerializeField] GameObject UIRoot;
    [SerializeField] bool startEnabled;
    bool UIEnabled;

    public bool UIEnabled1 { get => UIEnabled; }

    // Start is called before the first frame update
    void Start()
    {
        UIRoot.SetActive(startEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Open menu
            UIRoot.SetActive(true);
            UIEnabled = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //Closes menu
            UIRoot.SetActive(false);
            UIEnabled = false;
        }

    }
}
