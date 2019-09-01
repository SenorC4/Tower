using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldHealth : MonoBehaviour
{
    public int health = 200;
    public GameObject GameOver;

    public void TakeDamage()
    {
        health -= 10;

        if(health <= 0)
        {
            Destroy(gameObject);
            GameOver.SetActive(true);
        }
    }
}
