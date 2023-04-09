using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footsteps, sprinting;

    public void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            footsteps.enabled = true;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sprinting.enabled = true;
                footsteps.enabled = false;
            }
            else
            {
                sprinting.enabled = false;
                footsteps.enabled = true;
            }
        }
        else
        {
            footsteps.enabled = false;
            sprinting.enabled = false;
        }
    }
}
