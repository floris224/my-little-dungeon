using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float mousSens, mouseY, mouseX;
    public Vector3 dir;
    public GameObject playerBody;
    float rotY;

   
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

        //float mouseYClamped = Mathf.Clamp(mouseY, -90f, 90f);

        //dir = new Vector3(-mouseY, 0, 0);
        rotY += mouseY;
        rotY = Mathf.Clamp(rotY, -90, 90);
        Vector3 e = transform.eulerAngles;
        e.x = -rotY;
        transform.eulerAngles = e;



        //transform.Rotate(dir * mousSens * Time.deltaTime);
        /*transform.eulerAngles = new Vector3(
            Mathf.Clamp(transform.rotation.eulerAngles.x, -90, 90),
            transform.rotation.eulerAngles.y,
            transform.rotation.eulerAngles.z
        );*/
    }
}
