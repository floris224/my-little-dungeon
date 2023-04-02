using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 moveDir;
    public float hor, ver, moveSpeed;
    public RaycastHit hit;
    public bool grounded = false;
    public Transform feet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Walk(200);
        Run(300);
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        moveDir.x = hor;
        moveDir.z = ver;
    }
    public void Walk(float moveSpeed)
    {
        if (Input.GetButton("Horizontal"))
        {
            rb.AddForce(moveDir * moveSpeed * Time.deltaTime);
        }
        if (Input.GetButton("Vertical"))
        {
            rb.AddForce(moveDir * moveSpeed * Time.deltaTime);
        }
    }
    public void Run(float moveSpeed)
    {
        if (Input.GetButton("Horizontal") && Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(moveDir * moveSpeed * Time.deltaTime, ForceMode.Force);
        }
        if (Input.GetButton("Vertical") && Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(moveDir * moveSpeed * Time.deltaTime, ForceMode.Force);
        }
    }
}
