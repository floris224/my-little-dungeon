using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    public GameObject player;
    public Transform[] wayPoints;

    public float attackR = 1f;
    public int damage = 5;
    public int wayPointIndex;
    private NavMeshAgent agent;
    public float runToRange;
    public float attackRange;
    public float walkSpeed;
    public float runSpeed;
    
    // Start is called befo{re the first frame update
    void Start()
    {
        wayPointIndex = 0;
        agent = GetComponent<NavMeshAgent>();
        agent.height = GetComponent<CapsuleCollider>().height;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance > runToRange)
        {
            WayPoints();
            agent.speed = walkSpeed;
            agent.destination = (wayPoints[wayPointIndex].position);
        } 
        else
        {
            agent.speed = runSpeed;
            agent.destination = player.transform.position;
        }
        if(distance < attackRange)
        {
            player.GetComponent<Player>().health -= damage;
        }
    }
    public void WayPoints()
    {
        float distance = Vector3.Distance(transform.position, wayPoints[wayPointIndex].position);
        agent.destination = wayPoints[wayPointIndex].position;
        if (distance < 1f)
        {

            wayPointIndex++;
            if(wayPointIndex > 3)
            {
                wayPointIndex = 0;
            }

        }
        
    }
}
