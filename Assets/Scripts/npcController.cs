using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class npcController : MonoBehaviour
{
    private Animator anim;
    public Rigidbody player;
    public float speed = 0.02f;
    Vector3 playerPos = Vector3.zero;
    // Start is called before the first frame update

    void Awake()
    {
        anim = GetComponent<Animator>();
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

        if (anim.GetBool("isWalk") == true)
        {
            this.transform.position += Vector3.Normalize(player.position - this.transform.position) * speed;
            this.transform.LookAt(playerPos, Vector3.up);
        }

        if((player.position - this.transform.position).magnitude < 0.5)
        {
            anim.SetBool("isJump", true);
            anim.SetBool("isWalk", false);
            anim.SetBool("isIdle", false);
        }
        else
        {
            anim.SetBool("isJump", false);
            anim.SetBool("isWalk", true);
            anim.SetBool("isIdle", false);
        }
    }
}
