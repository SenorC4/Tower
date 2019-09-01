using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockPlacement : MonoBehaviour
{
    public GameObject block;
    public KeyCode objectHotkey = KeyCode.Alpha1;
    private GameObject current;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newObject();

        if(current != null)
        {
            MoveObject();
            place();
            
        }
    }

    private void newObject()
    {
        if (Input.GetKeyDown(objectHotkey))
        {
            if(current != null)
            {
                Destroy(current);
            }
            else
            {
                current = Instantiate(block);
            }
        }
    }

    private void MoveObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            Vector3 pos = new Vector3(hitInfo.point.x, 1f, hitInfo.point.z);

            current.transform.position = pos;
        }
    }

    private void place()
    {
        if (Input.GetMouseButtonDown(0))
        {
            current = null;
        }

    }



}
