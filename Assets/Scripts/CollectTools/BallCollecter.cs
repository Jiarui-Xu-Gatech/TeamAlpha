using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollecter : MonoBehaviour
{
    public bool gatherover = false;
    public int ballgathered = 0;

    // Start is called before the first frame update
    public void ReceiveBall()
    {
        if (gatherover)
        {
            ballgathered++;
            gatherover = false;
            this.gameObject.GetComponent<Controller_input>().allowedGather = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
