using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollector : MonoBehaviour
{
    public bool hasBall = false;

    // Start is called before the first frame update
    public void ReceiveBall()
    {
        hasBall = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
