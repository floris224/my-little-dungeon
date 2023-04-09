using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Skiekten : MonoBehaviour
{
    public Camera fpsCam;
    public RaycastHit hit;

    public AudioSource source;
    public AudioClip clip;

    public ParticleSystem muzzleFlash;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot(100f);
            source.PlayOneShot(clip);
            muzzleFlash.Play();

        }
    }



    void Shoot(float range)
    {
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(50f);
            }  

        }
    }
}


