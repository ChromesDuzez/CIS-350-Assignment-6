using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;
    protected bool weaponAte = false;
    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
    }

    public void EnemyEatsWeapon(Enemy enemy)
    {
        if(!weaponAte)
        {
            Debug.Log("Enemy eats weapon and gains 10 health.");
            enemy.addHealth(10f);
        }
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }

}
