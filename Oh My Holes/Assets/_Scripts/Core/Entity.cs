using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{

    public float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int i)
    {
        health -= i;
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    public void RecoverHealth(int i)
    {
        health += i;

    }
}
