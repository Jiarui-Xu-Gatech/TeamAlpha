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
    // Start is called before the first frame update

    void Awake()
    {
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim.SetBool("isWalk", false);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.attachedRigidbody != null)
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isWalk", true);
            anim.SetBool("isIdle", false);
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

        if (anim.GetBool("isWalk") == true)
        {
            //this.transform.position += Vector3.Normalize(player.position - this.transform.position) * speed;
            //this.transform.LookAt(playerPos, Vector3.up);
            navMeshAgent.SetDestination(player.position);
            anim.SetBool("isJump", false);
            anim.SetBool("isWalk", true);
            anim.SetBool("isIdle", false);
        }
        
        if(remainDis < 5)
        {
            anim.SetBool("isJump", true);
            anim.SetBool("isWalk", false);
            anim.SetBool("isIdle", false);
            navMeshAgent.isStopped = true;
        }
    }
}
