using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantSpider : Enemy
{
    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120;
        damage = 50;
    }
    protected override void Attack(int amount)
    {
        Debug.Log("Giant Spider Attacks " + amount + " time(s)!!");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("Giant Spider takes " + amount + " damage!!");
    }
}
