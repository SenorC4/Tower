using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour
{
    public Transform Sun;
    public Light[] lights;
    public float DaySpeed = 2;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, DaySpeed * Time.deltaTime);
        transform.LookAt(Vector3.zero);

        


        foreach(Light point in lights){
            if (Sun.position.y < 5)
            {
                point.intensity = 5;
                Debug.Log("Light on");
            }
            else
            {
                point.intensity = 0;
                Debug.Log("Light off");
            }
        }
    }
}
