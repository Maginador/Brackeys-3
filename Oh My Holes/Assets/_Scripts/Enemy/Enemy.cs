using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyData
{
    public enum EnemyNature { Seek, RunAway, ZigZag, Smart, Ranged, Melee}

}

public class Enemy : MonoBehaviour
{
    //enemy data
    [SerializeField] EnemyScriptableObject enemyData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAI();
    }

    void EnemyAI()
    {
        Debug.Log("AI Entry");
        switch (enemyData.nature)
        {
            case EnemyData.EnemyNature.Seek:
                Debug.Log("AI Seek");

                //Seek the player
                if (!CheckRange(enemyData.attackRange) && !CheckRange(enemyData.closeRange))
                {
                    Debug.Log("AI Check True");

                    Seek();
                }
                else
                {
                    Attack();
                }
                break;

            case EnemyData.EnemyNature.RunAway:
                //Run Away from the player
                if (CheckRange(enemyData.closeRange))
                {
                    RunAway();
                }
                break;

            case EnemyData.EnemyNature.ZigZag:
                //ZigZag in players Direction 
                break;

            case EnemyData.EnemyNature.Smart:
                //No ideia what the hell I am going to do here 
                break;

            case EnemyData.EnemyNature.Ranged:
                //Melee fighter. Seek player, get in attack range and run when player tries to get closer, attack when in range

                break;

            case EnemyData.EnemyNature.Melee:
                //Melee fighter. Seek player, get close and attack
                break; 
        }
    }


    //Enemy separate behaviours methods 

    void RunAway()
    {
        var direction = transform.position - Player._transform.position;

        Move(direction.normalized);
    }

    void Seek()
    {
        //Move to player's direction 

        var direction = Player._transform.position - transform.position;

        Move(direction.normalized);
    }

    bool CheckRange(int range)
    {
        Debug.Log("AI Check Range");
        Debug.Log("AI Player Pos : " + Player._transform.position);

        if (Vector3.Distance(Player._transform.position, transform.position) < range)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Attack()
    {
        Debug.Log("AI Attack");

    }

    void UseSkill()
    {
        Debug.Log("AI Skill");

    }


    void Move(Vector3 dir)
    {
        transform.Translate(dir*Time.deltaTime * enemyData.walkSpeed);
    }

}
