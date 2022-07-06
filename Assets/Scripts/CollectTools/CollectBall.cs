using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBall : MonoBehaviour
{

	void OnTriggerEnter(Collider c)
	{
		if (c.attachedRigidbody != null)
		{
			BallCollecter bc = c.attachedRigidbody.gameObject.GetComponent<BallCollecter>();
			if (bc != null && bc.gatherover)
			{
				bc.ReceiveBall();
				Destroy(this.gameObject);
				EventManager.TriggerEvent<BombBounceEvent, Vector3>(c.transform.position);
			}
		}
	}

    private void OnTriggerStay(Collider c)
    {
		if (c.attachedRigidbody != null)
		{
			BallCollecter bc = c.attachedRigidbody.gameObject.GetComponent<BallCollecter>();
			if (bc != null && bc.gatherover)
			{
				bc.ReceiveBall();
				Destroy(this.gameObject);
				EventManager.TriggerEvent<BombBounceEvent, Vector3>(c.transform.position);
			}
		}
	}
}