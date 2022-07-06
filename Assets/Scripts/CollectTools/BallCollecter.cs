using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollecter : MonoBehaviour
{
    public bool hasBall = false;
    Controller_input input;
    public bool gatherover = false;

    // Start is called before the first frame update
    public void ReceiveBall()
    {
        if (gatherover)
        {
            hasBall = true;
            gatherover = false;
            this.gameObject.GetComponent<Controller_input>().allowedGather = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
