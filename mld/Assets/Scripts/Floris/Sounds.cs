using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource ring;
    public AudioClip ringRing;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (Vector3.Distance(transform.position, player.transform.position));
        if (distance <= 2)
        {
            ring.enabled = true;
        }
    }
}