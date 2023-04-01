using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnitmatieBS : MonoBehaviour
{
    public Nav nav;
    // Start is called before the first frame update
    void Start()
    {
        nav.GetComponent<Nav>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
