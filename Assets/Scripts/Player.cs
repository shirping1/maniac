using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Controller
{
    [SerializeField]
    public int money { get; private set; }
    public Transform mousePos;

    void Start()
    {
        nowHP = maxHP;
    }

    void Update()
    {
        mousePos.position = Input.mousePosition;
        Move();
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
        else if (Input.GetMouseButton(1))
        {
            Attack();
        }

        Debug.DrawLine(transform.position, transform.position + transform.forward * 3, Color.blue);
    }

    private void Move()
    {
        transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    public override void Attack() //
    {
        //Instantiate(bullet, shootPos);
    }

    public override void GetDamage(int damage)
    {
        base.GetDamage(damage);
        nowHP -= damage;
        if (nowHP <= 0)
        {
            // 플레이어 죽음 처리
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            //GetDamage(other.gameObject.GetComponent<Bullet>().damage);
        }
    }
}
