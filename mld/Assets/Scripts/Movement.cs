using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor, vert;
    public Vector3 dir;
    public float stamina = 50f;
    
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        dir.x = hor;
        dir.z = vert;


        Walk(3);
        if (Input.GetKey(KeyCode.LeftShift) && stamina >= 0)
        {
            Run(4);
            stamina -= 20 * Time.deltaTime;
        }
        else
        {
            stamina += 5 * Time.deltaTime;
            if (stamina >= 50)
            {
                stamina = 50;
            }
        }
        
    }

    public void Walk(float walkSpeed)
    {
        transform.Translate(dir * walkSpeed * Time.deltaTime); 
    }
    public void Run(float runSpeed)
    {
        transform.Translate(dir * runSpeed * Time.deltaTime);
    }
}
