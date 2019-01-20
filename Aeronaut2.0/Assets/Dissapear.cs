using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{

	//public NewBehaviourScript ascript;
	//public GameObject camCam;



	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "RigidBodyFPSController")
		{
			Destroy(this.gameObject);
	
		}
        /*
        Vector3 pos = camCam.transform.position;
        pos.X -= f;
        buttonA.transform.position = pos;
        */
        
        GameObject varGameObject = GameObject.Find("[CameraRig]"); 
		varGameObject.GetComponent<NewBehaviourScript>().enabled = true;
    
	}
	/*
	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.name == "Parent")
		collision.gameObject.GetComponent<NewBehaviourScript>.enabled = false;
	}
    */


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}
}
	
