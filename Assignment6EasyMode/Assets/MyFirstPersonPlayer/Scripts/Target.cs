/*
 * Zach Wilson
 * Assignment 5B
 * This is the target script and it manages the health of the targets its attached to
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : Enemy
{


    protected override void Awake()
    {
        base.Awake();
        health = 50f;
    }

    public override void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 10)
        {
            weapon.EnemyEatsWeapon(this);
        }
        if(health <= 0)
        {
            Die();
        }
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Target can't Attack!!!");
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
