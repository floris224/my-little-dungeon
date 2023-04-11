using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class End : MonoBehaviour
{
    public Pickup Pickup;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        Pickup = GetComponent<Pickup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Pickup.currentQuestPoints == 5 )
        {
         
            if (Input.GetKeyDown(KeyCode.E) && Pickup.hit.transform.CompareTag("End"))
            {
                finish.SetActive(true);
            }
            

        }
    }
}
