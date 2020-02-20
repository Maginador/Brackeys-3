using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyScriptableObject : ScriptableObject
{
    public string enemyName;

    //movement
    public int walkSpeed, runSpeed;

    //View
    public int skillRange, attackRange, closeRange, longRange;

    //Ofensive
    public int damage, attackSpeed, skillCooldown;

    //Defensive
    public int health, evasion, defense;

    //Others?
    public GameObject skill, attack;
    public EnemyData.EnemyNature nature;

}