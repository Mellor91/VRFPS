using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using System;

public class testControl : MonoBehaviour {

    public VirtualJoystick moveJoystick;
    public Vector3 rotation { set; get; }

    private Transform camTransform;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

      /* if (Input.GetButtonDown("Fire1"))
        {
            transform.Rotate(transform.rotation.eulerAngles + new Vector3(0f,0.1f,0f));
        }*/

        

        poolInput();

        


       //transform.position += new Vector3(moveX * 0.1f, 0f , moveZ * 0.1f);

        Debug.Log(Camera.main.transform.rotation);
    }

    private Vector3 poolInput()
    {
        Vector3 dir = Vector3.zero;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (moveJoystick.inputDirection != Vector3.zero)
        {
            moveX = moveJoystick.inputDirection.x;
            moveZ = moveJoystick.inputDirection.z;
        }


        dir.x = moveX;
        dir.z = moveZ;

       return dir;
    }


}
