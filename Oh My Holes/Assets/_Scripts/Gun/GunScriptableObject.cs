using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "ScriptableObjects/Gun", order = 1)]
public class GunScriptableObject : ScriptableObject
{
    public string gunName;
    public int damage, fireRate, speed;
    public GameObject bulletPrefab;
    public GameObject gunAsset;
}