using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform hand;
    public RaycastHit hit;
    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(fpsCam.transform.position, transform.forward, out hit, 50f))
            {
                Debug.Log("Hallo");

                if (hit.transform.tag == ("Weapon"))
                {
                    hit.transform.SetParent(hand);
                    hit.collider.enabled = false;
                    hit.transform.position = hand.position;
                    hit.transform.rotation = hand.rotation;
                    hit.transform.GetComponent<Skiekten>().enabled = true;

                }

            }
        }

    }
}
