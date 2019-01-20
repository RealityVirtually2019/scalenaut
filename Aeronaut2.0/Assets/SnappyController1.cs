using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappyController1 : MonoBehaviour {

	public float moveSpeed;
	private float maxSpeed = 5f;

	private Vector3 input;

	void Awake () {

		SnappyController1 otherScript = GetComponent<SnappyController1>();
		otherScript.enabled = false;

	}




	void OnCollisionEnter (Collision col) 
	{


		if (col.gameObject.name == "Projectile") {



			SnappyController1 otherScript = GetComponent<SnappyController1> ();
			otherScript.enabled = true;

		}

	}





	void Update () {



	}

}