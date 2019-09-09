using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldHealth : MonoBehaviour
{
    public float health = 200f;
    public GameObject GameOver;

    public Image healthBar;

    public void TakeDamage()
    {
        health -= 10;
        healthBar.fillAmount = health / 200f;

        if(health <= 0)
        {
            Destroy(gameObject);
            GameOver.SetActive(true);
        }
    }
}
