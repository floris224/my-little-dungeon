using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject finish;
    
    public void OnTriggerEnter(Collider other)
    {
        finish.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
}
