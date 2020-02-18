using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int bDamage;
    float bulletSpeed;

    internal void Initialize(int damage, float speed)
    {
        bDamage = damage;
        bulletSpeed = speed;
        Destroy(this.gameObject, 5);
    }


    public void Update()
    {
        transform.Translate(transform.forward * bulletSpeed * Time.deltaTime,Space.World);
    }
}