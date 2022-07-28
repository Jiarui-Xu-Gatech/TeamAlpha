using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody), typeof(CapsuleCollider))]
[RequireComponent(typeof(Controller_input))]
public class Basic_control : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rbody;
    private Controller_input cinput;
    private AnimatorStateInfo stateinfo;

    public float forwardMaxSpeed = 1f;
    public float turnMaxSpeed = 1f;

    public bool isGathering;
    public bool isJumping;
    public bool gethit;
    public bool isDying;

    void Awake()
    {

        anim = GetComponent<Animator>();

        if (anim == null)
            Debug.Log("Animator could not be found");

        rbody = GetComponent<Rigidbody>();

        if (rbody == null)
            Debug.Log("Rigid body could not be found");

        cinput = GetComponent<Controller_input>();

        if (cinput == null)
            Debug.Log("CharacterController could not be found");

    }


    // Start is called before the first frame update
    void Start()
    {
        isGathering = false;
        isJumping = false;
        gethit = false;
        isDying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Gathering"))
        {
            isGathering = true;
        }
        else
        {
            isGathering = false;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
        {
            gethit = true;
        }
        else
        {
            gethit = false;
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Death"))
        {
            isDying = true;
        }
        else
        {
            isDying = false;
        }

        float inputForward = 0f;
        float inputTurn = 0f;
        inputForward = cinput.Forward;
        inputTurn = cinput.Turn;
        if (isGathering == false)
        {
            rbody.MovePosition(rbody.position + this.transform.forward * 5 * inputForward * Time.deltaTime * forwardMaxSpeed);
            rbody.MoveRotation(rbody.rotation * Quaternion.AngleAxis(100 * inputTurn * Time.deltaTime * turnMaxSpeed, Vector3.up));
        }



        anim.SetFloat("vely", inputForward);
        anim.SetFloat("velx", inputTurn);
        anim.SetBool("Gathering", cinput.Gather & !isGathering & !gethit & !isJumping);
        anim.SetBool("Jumping", cinput.Jump & !isJumping & !gethit & !isGathering);


        //Todo: implement the following
        anim.SetBool("Gethit", this.GetComponent<Controller_input>().allowedhit & !gethit);
        anim.SetBool("HPzero", this.GetComponent<Controller_input>().dead & !isDying);
    }
}
