using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime);
    }
}
