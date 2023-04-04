using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    public GameObject player;
    public Transform[] wayPoints;
    public Animator animator;

    public int damage = 5;
    public int wayPointIndex;
    private NavMeshAgent agent;
    public float runToRange;
    public float attackRange;
    
    public float runSpeed;
    public float timer;
    public bool animbegin;
    
    // Start is called befo{re the first frame update
    void Start()
    {
        wayPointIndex = 0;
        agent = GetComponent<NavMeshAgent>();
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animbegin == false)
        {


            // defineren wat de distance in houd,
            float distance = Vector3.Distance(transform.position, player.transform.position);

            // als distance groter is dan dan de runtorange float dan zal de ai van watpoint naar waypoint gaan.
            if (distance > runToRange)
            {
                
                // functie waypoints wordt hier aangeroepen om uitgevoerd te worden.
                WayPoints();
                
               
                // hier wordt de destination van de ai bepaald.
                agent.destination = (wayPoints[wayPointIndex].position);
                if (animbegin == false)
                {
                    animator.SetTrigger("DoWalking");
                }


            }
            else
            {
                agent.speed = runSpeed;
                agent.destination = player.transform.position;
            }
            // als de distance kleiner is dan de attack range zal de ai dmg op de player doen en de animatie van attack uit voeren.
            if (distance < attackRange)
            {
                player.GetComponent<Player>().health -= damage;
                animator.SetTrigger("DoAttack");
                agent.speed = 0;
            }
            
            
        }
        // als de waypoint index 0 is zal de ai de animatie kontkrabben uit voeren en als de timer 6 seconde heeft gehad zal de ai weer door lopen.
        if (wayPointIndex == 0)
        {
            
            animator.SetTrigger("DoKontKrabben");
            agent.speed = 0;
            animbegin = true;
            Timer(6);

        }
    }

    // hier wordt de functie waypoints vandaan geroepen. het zorgt er voor dat de ai weet naar welk waypoint hij zal moeten gaan lopen. en als de distance tot het waypoint klein genoeg is zal hij naar de volgende index gaan.
    public void WayPoints()
    {
        float distance = Vector3.Distance(transform.position, wayPoints[wayPointIndex].position);
        agent.destination = wayPoints[wayPointIndex].position;
        if (distance < 1f)
        {
            // als de waypoint index boven de 3 komt zal hij  terug gezet worden naar 0 om de ai in een loop te laten lopen.
            wayPointIndex++;
            if(wayPointIndex > 3)
            {
                wayPointIndex = 0;
                
            }

        }
        
    }

    // hier wordt de timer vandaan geroepen.
    public void Timer(float time)
    {
        
        timer += 1 * Time.deltaTime;
        if (timer >= time && animbegin == true)
        { 
            agent.speed = 3;
            animbegin = false;
            timer = 0;
            wayPointIndex++;
            
                
        }
    }
}
