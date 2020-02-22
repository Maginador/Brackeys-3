using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] string tagToDamage;
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

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagToDamage)
        {
            var e = other.GetComponent<Entity>();
            e.TakeDamage(bDamage);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}