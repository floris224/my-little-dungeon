using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor, vert, speed;
    public Vector3 dir;
    
    void Update()
    {
        hor = Input.GetAxis("Horizontal");// * Time.deltaTime;
        vert = Input.GetAxis("Vertical");// * Time.deltaTime ;

        dir.x = hor;
        dir.z = vert;

        transform.Translate(dir * speed * Time.deltaTime);
        
    }
}
