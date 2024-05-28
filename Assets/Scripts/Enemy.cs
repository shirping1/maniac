using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Controller
{
    void Start()
    {
        nowHP = maxHP;
    }

    private void AI()
    {

    }

    private void DropItem()
    {
        //Instantiate(myWeapon);
    }

    public override void Attack()
    {

    }

    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
        nowHP -= damage;
        if (nowHP <= 0)
        {
            DropItem();
        }
    }
}