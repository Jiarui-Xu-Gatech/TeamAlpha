using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider others)
    {
        if (others.name == "Protagonist")
        {
            //others.GetComponent<PlayerScript>().points++;
            //Heal the protagonist but the HP limit is 120
            int HP = GameObject.Find("Protagonist").GetComponent<Controller_input>().currentHP;
            if (HP <= 100)
            {
                GameObject.Find("Protagonist").GetComponent<Controller_input>().currentHP += 20;
            }
            Destroy(gameObject); //this destorys things
        }
    }
}
