using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
public class npcController : MonoBehaviour
{
    private Animator anim;
    public Rigidbody player;
    public float speed = 0.02f;
    private NavMeshAgent navMeshAgent;
    Vector3 playerPos = Vector3.zero;
    float remainDis;
    bool seePlayer;
    Vector3 vel;
    Vector3 desiredVel;
    float angleToTurn;
    BoxCollider new_collider;
    // Start is called before the first frame update

    void Awake()
    {
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim.SetBool("isWalk", false);
        seePlayer = false;
        vel = navMeshAgent.velocity.normalized;
        desiredVel = navMeshAgent.desiredVelocity.normalized;
        angleToTurn = Vector3.Angle(vel, desiredVel);
        new_collider = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.attachedRigidbody != null)
        {
            seePlayer = true;
        }
    }

    private void OnTriggerExit(Collider c)
    {
        //if (c.attachedRigidbody != null)
        //{
        //    anim.SetBool("isJump", false);
        //    anim.SetBool("isWalk", true);
        //    anim.SetBool("isIdle", false);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        remainDis = (playerPos - navMeshAgent.transform.position).magnitude;
        vel = navMeshAgent.velocity.normalized;
        desiredVel = navMeshAgent.desiredVelocity.normalized;
        angleToTurn = Vector3.Angle(vel, desiredVel);

        if (seePlayer)
        {
            if(remainDis > 5)
            {
                navMeshAgent.SetDestination(player.position);
                anim.SetBool("isJump", false);
                anim.SetBool("isWalk", true);
                anim.SetBool("isIdle", false);
                transform.rotation = Quaternion.LookRotation(navMeshAgent.velocity.normalized);
            }
            else
            {
                anim.SetBool("isJump", true);
                anim.SetBool("isWalk", false);
                anim.SetBool("isIdle", false);
                //transform.rotation = Quaternion.LookRotation(navMeshAgent.velocity.normalized);
            }

            new_collider.size = new Vector3(1, 1, 1);
            new_collider.center = new Vector3(0, 0, 0);
        }

    }
}
