using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

[RequireComponent(typeof(SteamVR_TrackedObject))]

public class myTouchPad : MonoBehaviour
{

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    public GameObject player;
    public Transform scaleplayer;
    public bool moveEnabled;

    
    public Transform relativeTransform;
    private float speedMove = 0.04f;
    private float speedScale;

    /*
    public Vector3 camCam;
    public Quaternion lastPos;
    public float turnSpeed = 20f;
    */


    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
       // camCam = Camera.main.transform;

    }


    // Use this for initialization
    void Start()
    {
        moveEnabled = true;
    }

    public void SetMove(bool status)
    {
        moveEnabled = status;
    }

    void Update()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    // Update is called once per frame
    void FixedUpdate()
    {   /*

        posCam = camCam.position - transform.position;
        posCam.y = 0;
        lastPos = Quaternion.LookRotation(-posCam);
        

        */
        speedScale = scaleplayer.localScale.x;




        if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad) )
        {

            Vector2 touchpad = (device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0));
            print("Pressing Touchpad");


     

            if (touchpad.y > 0.7f && moveEnabled)
            {


                //player.transform.position += -relativeTransform.rotation.forward;

                //player.transform.position = player.transform.position + Vector3.forward * 0.05f;

                //player.transform.position = new Vector3( player.transform.position.x + -relativeTransform.forward.x*speedMove* speedScale, player.transform.position.y,player.transform.position.z+ -relativeTransform.forward.z*speedMove* speedScale);
                player.transform.position = new Vector3(player.transform.position.x + relativeTransform.forward.x * speedMove * speedScale, player.transform.position.y, player.transform.position.z + relativeTransform.forward.z * speedMove * speedScale);
                //player.transform.position *= speedMove;

                //player.transform.position = new Vector3(player.transform.position.x + 0.01f, player.transform.position.y, player.transform.position.z);
                //player.transform.position = 
                // player.transform.position = player.transform.position + Camera.main.transform.forward * distance * Time.deltaTime;
                //player.transform.Translate = player.transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
                //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                print("Moving Up");
    
            }

            
            else if (touchpad.y < -0.7f )
            {
                //player.transform.position += relativeTransform.forward;
                //player.transform.position = player.transform.position - Vector3.forward * 0.05f;
                //player.transform.position = new Vector3(player.transform.position.x + relativeTransform.forward.x * speedMove*speedScale, player.transform.position.y, player.transform.position.z + relativeTransform.forward.z * speedMove* speedScale);
                player.transform.position = new Vector3(player.transform.position.x + -relativeTransform.forward.x * speedMove * speedScale, player.transform.position.y, player.transform.position.z + -relativeTransform.forward.z * speedMove * speedScale);
                print("Moving Down");
            }

            if (touchpad.x > 0.7f)
            {
                //player.transform.position += -relativeTransform.right;
                //player.transform.position = player.transform.position + Vector3.right * 0.05f;


                //player.transform.position = new Vector3(player.transform.position.x + -relativeTransform.right.x * speedMove* speedScale, player.transform.position.y, player.transform.position.z + -relativeTransform.right.z * speedMove*speedScale);
                player.transform.position = new Vector3(player.transform.position.x + relativeTransform.right.x * speedMove * speedScale, player.transform.position.y, player.transform.position.z + relativeTransform.right.z * speedMove * speedScale);


                print("Moving Right");

            }

            else if (touchpad.x < -0.7f)
            {
                //player.transform.position += relativeTransform.right;
                //player.transform.position = player.transform.position - Vector3.right * 0.05f;
                //player.transform.position = new Vector3(player.transform.position.x + relativeTransform.right.x * speedMove* speedScale, player.transform.position.y, player.transform.position.z + relativeTransform.right.z * speedMove* speedScale);
                player.transform.position = new Vector3(player.transform.position.x + -relativeTransform.right.x * speedMove * speedScale, player.transform.position.y, player.transform.position.z + -relativeTransform.right.z * speedMove * speedScale);
                print("Moving left");
            }
            

        }
    }

}