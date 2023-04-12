using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public GameObject quest;


    private void OnTriggerEnter(Collider other)
    {
        quest.SetActive(true);
    }
}
