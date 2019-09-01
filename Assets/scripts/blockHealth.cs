using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockHealth : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage()
    {
        health -= 10;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
