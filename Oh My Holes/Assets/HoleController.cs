using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleController : MonoBehaviour
{


    [SerializeField] int moneyGenerated;
    [SerializeField] float generationCooldown;
    [SerializeField] MonsterSpawner spawner; 
    [SerializeField] Animator anim; 
    [SerializeField] Text text; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("GenerateCash", generationCooldown);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateCash()
    {
        GameRSSManager.instance.AddCash(moneyGenerated);
        text.text = "+" + moneyGenerated;
        anim.SetTrigger("Cash");
        Invoke("GenerateCash", generationCooldown);
    }
}
