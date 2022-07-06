using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public GameObject Human;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(Human.transform.position.x, Human.transform.position.y + 10, Human.transform.position.z -10);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Human.transform.position.x, Human.transform.position.y + 10, Human.transform.position.z -10);
    }
}
