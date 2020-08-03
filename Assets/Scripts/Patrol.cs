using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol : MonoBehaviour {

    public GameObject player;
    public Transform[] points;
    public bool isPatrolMode;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private Animator anim;
    bool isChasing = false;

    void Start () {
        anim = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        
        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        //agent.autoBraking = false;
        
        anim.SetBool("isPatrolMode", isPatrolMode);
        if(isPatrolMode) GotoNextPoint();
    }


    void GotoNextPoint() {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update () {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (isPatrolMode && !agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
        if(isChasing) agent.destination = player.transform.position;
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if(distanceToPlayer < 2) {
            // GAME OVER
            Debug.Log("BUSTED!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.ToString());
        if(other.tag == "Player"){
            anim.SetTrigger("playerFound");
            agent.speed = 10;
            isChasing = true;
        }
    }
}