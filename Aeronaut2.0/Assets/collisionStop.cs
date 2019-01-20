using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionStop : MonoBehaviour {
    private myTouchPad touchPad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("HIT WALL 1");
        if (collider.gameObject.tag == "wall")
        {
            touchPad.SetMove(false);
            Debug.Log("HIT WALL2");
        }
    }
  
}
