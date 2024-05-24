using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField]
    public float moveSpeed { get; protected set; }
    protected int maxHP;
    protected int nowHP;
    protected Weapon myWeapon;

    virtual public void Attack()
    {

    }

    virtual public void GetDamage(int damage)
    {

    }
}
