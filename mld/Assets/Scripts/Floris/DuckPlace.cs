using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckPlace : MonoBehaviour
{
    public float frequency = 1.0f;
    public float amplitude = 1.0f;
    public float maxPosition = 1.0f;
    public float minPosition = -1.0f;

    public float phase = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
        float waveValue = amplitude * Mathf.Sin(2 * Mathf.PI * frequency * Time.time + phase);

        
        float positionOffset = Mathf.PingPong(Time.time, 1.0f) * (maxPosition - minPosition) + minPosition;

     
        Vector3 position = transform.position;
        position.y = waveValue + positionOffset;
        transform.position = position;
    }
}

