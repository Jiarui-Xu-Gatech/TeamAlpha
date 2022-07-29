using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_input : MonoBehaviour
{
    private float filteredForwardInput = 0f;
    private float filteredTurnInput = 0f;

    public bool InputMapToCircular = true;

    public float forwardInputFilter = 5f;
    public float turnInputFilter = 5f;

    private float forwardSpeedLimit = 1f;

    public bool allowedGather = false;
    public bool endReached = false;
    public bool allowedhit = false;

    public int currentHP = 100;

    public float Forward
    {
        get;
        private set;
    }

    public float Turn
    {
        get;
        private set;
    }

    public bool Gather
    {
        get;
        set;
    }

    public bool Jump
    {
        get;
        set;
    }

    public bool Gethit
    {
        get;
        set;
    }

    public bool dead
    {
        get;
        set;
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        bool isgather = Input.GetButton("Gather");
        bool isJump = Input.GetButton("Jump");
        h = h * Mathf.Sqrt(1f - 0.5f * v * v);
        v = v * Mathf.Sqrt(1f - 0.5f * h * h);

        filteredForwardInput = Mathf.Clamp(Mathf.Lerp(filteredForwardInput, v,
    Time.deltaTime * forwardInputFilter), -forwardSpeedLimit, forwardSpeedLimit);

        filteredTurnInput = Mathf.Lerp(filteredTurnInput, h, Time.deltaTime * turnInputFilter);

        Forward = filteredForwardInput;
        Turn = filteredTurnInput;
        Jump = isJump;


        //Gathering implementation
        Gather = isgather;
        if (Gather && allowedGather && this.GetComponent<Basic_control>().isGathering)
        {
            this.GetComponent<BallCollecter>().gatherover = Gather;
        }
        //HP equals 0 implementation
        if (!dead)
        {
            if (currentHP <= 0)
            {
                dead = true;
            }
        }

        //End Gaming
        if (this.GetComponent<BallCollecter>().hasBall & endReached)
        {
            SceneManager.LoadScene("meun");
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>()!= null)
        {
            allowedGather = true;
        }
        if (collision.name == "Endpoint") 
        {
            endReached = true;
        }
        if (collision.name.Contains("NPC"))
        {
            allowedhit = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        allowedGather = false;
        endReached = false;
        allowedhit = false;
    }
}
