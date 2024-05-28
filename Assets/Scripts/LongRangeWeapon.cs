using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongRangeWeapon : Weapon
{
    public Bullet bullet;
    public Transform shootPos;

    public override void UseWeapon()
    {
        Instantiate(bullet, shootPos);
    }
}
