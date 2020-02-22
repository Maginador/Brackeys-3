using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleController : MonoBehaviour, IUpgradeable
{

    //HoleUpgrading
    [SerializeField] UpgradesScriptableObjects[] upgrades;
    int currentUpgrade;

    //Cash
    [SerializeField] int moneyGenerated;
    [SerializeField] float generationCooldown;

    //Enemy Spawning
    [SerializeField] int spawnRate;

    [SerializeField] Animator anim; 
    [SerializeField] Text text;


    [SerializeField] ContextUI UI; 
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GenerateCash", generationCooldown);
        MonsterSpawner.instance.RegisterHole(this);
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


    //Upgrading Controller

    void Upgrade()
    {

    }

    public void NextUpgrade()
    {
        throw new System.NotImplementedException();
    }

    public void LastUpgrade()
    {
        throw new System.NotImplementedException();
    }

    public void DoUpgrade()
    {
        throw new System.NotImplementedException();
    }
}
