using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GunScriptableObject gunType;
    [SerializeField] Transform gunPivot;
    GameObject gunAsset;
    [SerializeField] Transform bulletPivot;


    float timer; 

    internal void UpdateGun(GunScriptableObject gunType)
    {
        this.gunType = gunType;
        InitializeGun();
    }

    private void InitializeGun()
    {
        if (gunAsset)
        {
            Destroy(gunAsset);
        }
        else
        {
            //TODO : Add Pool
            gunAsset = Instantiate(gunType.gunAsset, gunPivot.position, gunPivot.rotation);
            gunAsset.transform.parent = gunPivot;
        }
    }

    public GunScriptableObject GetGunData()
    {
        return gunType;
    }

    public void Shoot()
    {
        //TODO : Add Pool
        var bullet = Instantiate(gunType.bulletPrefab, bulletPivot.position, bulletPivot.rotation);
        bullet.GetComponent<Bullet>().Initialize(gunType.damage, gunType.speed);
    }


    public void Update()
    {
        if (gunType == null) return;
        if (Input.GetButton("Fire1") && timer < Time.time)
        {
            Shoot();
            timer = Time.time + (10f / gunType.fireRate);
        }
    }


}