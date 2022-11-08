using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120f;
    }
    protected override void Attack(int amount)
    {
        Debug.Log("Golem Attacks " + amount + " time(s)!!");
        GameManager.Instance.score += (amount + damage);
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Golem takes " + amount + " damage!!");
    }

}
