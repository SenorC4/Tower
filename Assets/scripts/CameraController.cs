using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public float panSpeed = 20;
    public float panBorderThickness = 10f;
    public Vector2 PanLimit;
    public float scrollSpeed = 5f;
    public float minY = 5f;
    public float maxY = 35f;


    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;

        if (Input.GetKey("w")) //|| Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s")) //|| Input.mousePosition.y <= panBorderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d")) //|| Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a")) //|| Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, -PanLimit.x + 20, PanLimit.x - 20);
        pos.z = Mathf.Clamp(pos.z, -PanLimit.y - 10, PanLimit.y - 20);

        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;


        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main");
        }

        transform.position = pos;
    }
}
