using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public float xpos;
    public float zpos; 
    public float count;
    public float speed;
    public Vector3 direction = Vector3.zero;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
      
        for(int i = 0; i <= count; i++)
        {
            xpos = Random.Range(-90, 90);
            zpos = Random.Range(-60, -90);
            Instantiate(enemy, new Vector3(xpos, 0, zpos), Quaternion.identity);
            

            yield return new WaitForSeconds(0.1f);
            

        }

        for (int i = 0; i <= count; i++)
        {
            xpos = Random.Range(60, 90);
            zpos = Random.Range(-90, 90);
            Instantiate(enemy, new Vector3(xpos, 0, zpos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            

        }

        for (int i = 0; i <= count; i++)
        {
            xpos = Random.Range(-90, 90);
            zpos = Random.Range(60, 90);
            Instantiate(enemy, new Vector3(xpos, 0, zpos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            

        }

        for (int i = 0; i <= count; i++)
        {
            xpos = Random.Range(-60, -90);
            zpos = Random.Range(90, -90);
            Instantiate(enemy, new Vector3(xpos, 0, zpos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            

        }

    }



   
}
