using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float mousSens, mouseY, mouseX;
    public Vector3 dir;
    public GameObject playerBody;

   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

   
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") *  mousSens;
        mouseY = Input.GetAxis("Mouse Y") *  mousSens;

        dir = new Vector3(0, mouseX, 0);
        playerBody.transform.Rotate(dir * mousSens * Time.deltaTime);

        dir = new Vector3(-mouseY, 0, 0);
        transform.Rotate(dir * mousSens * Time.deltaTime);

        
    }
}
