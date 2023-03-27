using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{

    public GameObject player;
    public float aggroR = 7f;
    public float attackR = 1f;

    public int damage = 5;

    public float walkSpeed;
    public float runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // wanneer ze in de aggro range zijn van de speler zal de snelheid van 7 naar 1000 gaan. wanneer ze niet in de range zijn zal de snelheid veranderen naar 7
        GetComponent<NavMeshAgent>().SetDestination(player.transform.position);

        if (Vector3.Distance(transform.position, player.transform.position) <= aggroR)
        {
            GetComponent<NavMeshAgent>().speed = runSpeed;

        }
        else
        {
            GetComponent<NavMeshAgent>().speed = walkSpeed;
        }

      


    }
    public void OnCollisionEnter(Collision collision)
    {
        if(Vector3.Distance(transform.position, player.transform.position)<= attackR)
        {
            player.GetComponent<Player>().health -=damage;
        }
        
        if(player.GetComponent<Player>().health <= 0)
        {
            Debug.Log("You Died");
            Time.timeScale = 0;
        }
    }
}
