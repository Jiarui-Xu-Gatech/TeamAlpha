using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlantControllerScript : MonoBehaviour
{
    bool IsIn = false;
    public float Speed = 1;
    float angle = -45;
    public GameObject man;
    public GameObject leaf1;
    public GameObject leaf2;
    public GameObject leaf3;
    public GameObject leaf4;
    private Animator animator;

    //void OnTriggerEnter(Collider c)
    //{
    //    if (IsIn)
    //    {
    //        BallCollector bc = c.attachedRigidbody.gameObject.GetComponent<BallCollector>();
    //        if (!(bc == null))
    //        {
    //            bc.ReceivePlant();
    //            IsIn = bc.GetBool();
    //        }
    //    }
        
    //}
        // Start is called before the first frame update
        void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Animate(string boolName,bool TrueOrFalse)
    {
        animator.SetBool(boolName, TrueOrFalse);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(man.transform.position, this.transform.position) > 3.5)
        {
            IsIn = false;
        }
        else
        {
            IsIn = true;
        }
        if (IsIn)
        {
            if (leaf1.transform.position.y-this.transform.position.y > 0)
            {
                leaf1.transform.position = new Vector3(leaf1.transform.position.x, leaf1.transform.position.y- Time.deltaTime * Speed, leaf1.transform.position.z);
                leaf2.transform.position = new Vector3(leaf2.transform.position.x, leaf2.transform.position.y - Time.deltaTime * Speed, leaf2.transform.position.z);
                leaf3.transform.position = new Vector3(leaf3.transform.position.x, leaf3.transform.position.y - Time.deltaTime * Speed, leaf3.transform.position.z);
                leaf4.transform.position = new Vector3(leaf4.transform.position.x, leaf4.transform.position.y - Time.deltaTime * Speed, leaf4.transform.position.z);
                leaf1.transform.rotation = Quaternion.Euler(leaf1.transform.rotation.x - Time.deltaTime * Speed*9 , leaf1.transform.rotation.y, leaf1.transform.rotation.z);
                leaf2.transform.rotation = Quaternion.Euler(leaf2.transform.rotation.x + Time.deltaTime * Speed * 9, leaf2.transform.rotation.y, leaf2.transform.rotation.z);
                leaf3.transform.rotation = Quaternion.Euler(leaf3.transform.rotation.x, leaf3.transform.rotation.y, leaf3.transform.rotation.z - Time.deltaTime * Speed * 9);
                leaf4.transform.rotation = Quaternion.Euler(leaf4.transform.rotation.x, leaf4.transform.rotation.y, leaf4.transform.rotation.z + Time.deltaTime * Speed * 9);
            }
            Animate("IsIn", true);
            



        }
        else
        {
            if (leaf1.transform.position.y - this.transform.position.y < 1)
            {
                leaf1.transform.position = new Vector3(leaf1.transform.position.x, leaf1.transform.position.y + Time.deltaTime * Speed, leaf1.transform.position.z);
                leaf2.transform.position = new Vector3(leaf2.transform.position.x, leaf2.transform.position.y + Time.deltaTime * Speed, leaf2.transform.position.z);
                leaf3.transform.position = new Vector3(leaf3.transform.position.x, leaf3.transform.position.y + Time.deltaTime * Speed, leaf3.transform.position.z);
                leaf4.transform.position = new Vector3(leaf4.transform.position.x, leaf4.transform.position.y + Time.deltaTime * Speed, leaf4.transform.position.z);
                leaf1.transform.rotation = Quaternion.Euler(leaf1.transform.rotation.x + Time.deltaTime * Speed * 9, leaf1.transform.rotation.y, leaf1.transform.rotation.z);
                leaf2.transform.rotation = Quaternion.Euler(leaf2.transform.rotation.x - Time.deltaTime * Speed * 9, leaf2.transform.rotation.y, leaf2.transform.rotation.z);
                leaf3.transform.rotation = Quaternion.Euler(leaf3.transform.rotation.x, leaf3.transform.rotation.y, leaf3.transform.rotation.z + Time.deltaTime * Speed * 9);
                leaf4.transform.rotation = Quaternion.Euler(leaf4.transform.rotation.x, leaf4.transform.rotation.y, leaf4.transform.rotation.z - Time.deltaTime * Speed * 9);
            }
            Animate("IsIn", false);
        }

    }
}
