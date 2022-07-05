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

    public float forwardMaxSpeed = 1f;
    public float turnMaxSpeed = 1f;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputForward = 0f;
        float inputTurn = 0f;
        inputForward = cinput.Forward;
        inputTurn = cinput.Turn;
        if (cinput.Gather == false)
        {
            rbody.MovePosition(rbody.position + this.transform.forward * 4 * inputForward * Time.deltaTime * forwardMaxSpeed);
            rbody.MoveRotation(rbody.rotation * Quaternion.AngleAxis(100 * inputTurn * Time.deltaTime * turnMaxSpeed, Vector3.up));
        }

        anim.SetFloat("vely", inputForward);
        anim.SetFloat("velx", inputTurn);
        anim.SetBool("Gathering", cinput.Gather);
        anim.SetBool("Jumping", cinput.Jump);
    }
}
