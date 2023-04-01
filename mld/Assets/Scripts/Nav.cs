using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    public GameObject player;
    public Transform[] wayPoints;
    public Animator animator;

    public float attackR = 1f;
    public int damage = 5;
    public int wayPointIndex;
    private NavMeshAgent agent;
    public float runToRange;
    public float attackRange;
    public float walkSpeed;
    public float runSpeed;
    public int startDelay;
    public bool animFin;
    public float timer;
    public bool animbegin;
    
    // Start is called befo{re the first frame update
    void Start()
    {
        wayPointIndex = 0;
        agent = GetComponent<NavMeshAgent>();
        agent.height = GetComponent<CapsuleCollider>().height;
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animbegin == false)
        {



            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance > runToRange)
            {
                WayPoints();
                agent.speed = walkSpeed;
                agent.destination = (wayPoints[wayPointIndex].position);
                if (animFin == false)
                {
                    animator.SetTrigger("DoWalking");
                }


            }
            else
            {
                agent.speed = runSpeed;
                agent.destination = player.transform.position;
            }
            if (distance < attackRange)
            {
                player.GetComponent<Player>().health -= damage;
            }
            
            
        }
        if (wayPointIndex == 0)
        {
            
            animator.SetTrigger("DoKontKrabben");
            walkSpeed = 0;
            Timer();
            wayPointIndex++;

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
    public void Timer()
    {
        animbegin = true;
        timer += 1 * Time.deltaTime;
        if(timer >= 6)
        {
            walkSpeed = 3;
            animbegin = false;
            timer = 0;
        }
    }
}
