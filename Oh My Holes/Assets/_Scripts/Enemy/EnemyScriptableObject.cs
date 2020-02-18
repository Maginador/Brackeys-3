using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyScriptableObject : ScriptableObject
{
    public string enemyName;
    public int damage, moveSpeed, health;
    public GameObject hability;
    public enum EnemyNature {Seek, Run, ZigZag, Smart}
    public EnemyNature nature;
}