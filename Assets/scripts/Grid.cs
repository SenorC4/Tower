using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // Start is called before the first frame update
    private float size = 2f;


    public Vector3 GetNearestPoint(Vector3 pos)
    {
        pos -= transform.position;

        int x = Mathf.RoundToInt(pos.x / size);
        int y = 1;
        int z = Mathf.RoundToInt(pos.z / size);

        Vector3 result = new Vector3((float)x * size, y, (float)z * size);

        result += transform.position;

        return result;
    }

    /**
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        for(float x = 0; x < 40; x += size)
        {
            for(float z = 0; z < 40; z += size)
            {
                var point = GetNearestPoint(new Vector3(x, 1f, z));
                Gizmos.DrawSphere(point, 0.5f);
            }
        }
    }
    **/

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
