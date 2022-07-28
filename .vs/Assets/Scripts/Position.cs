using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject Human;

    private Vector3 offset;

    private Vector3 change;
    private Vector3 Ychange = new Vector3(0f, 10f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0f, 10f, -10f);
        transform.position = Human.transform.position + offset;
        
    }

    // Update is called once per frame
    void Update()
    {
        change = -Human.transform.forward * 10;
        transform.position = Human.transform.position + Ychange + change;
        //transform.position = Human.transform.position + offset;
        //this.transform.position = Vector3.SmoothDamp(transform.position, Human.transform.position + offset, ref ve, 0);

    }
}
