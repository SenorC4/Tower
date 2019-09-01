using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class attack : MonoBehaviour
{
    // Start is called before the first frame update

    Transform target;
    NavMeshAgent agent;

    void Start()
    {
        target = GoldBlock.instance.gold.transform;
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(10);
        agent.SetDestination(target.position);
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        goldHealth gold = hitInfo.GetComponent<goldHealth>();
        blockHealth block = hitInfo.GetComponent<blockHealth>();

        if (gold != null)
        {
            gold.TakeDamage();
        }else if(block != null)
        {
            block.TakeDamage();
        }
    }
}
