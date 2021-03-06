﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25f;
    public VirtualJoystick joystick;
    GameObject joystickObj;

    private Rigidbody controller;
    private Transform camTransform;


	// Use this for initialization
	void Start () {
        controller = GetComponent<Rigidbody>();
        controller.maxAngularVelocity = terminalRotationSpeed;
        controller.drag = drag;
        camTransform = Camera.main.transform;
        joystickObj = GameObject.Find("VirtualJoystickContainer");
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 move = Vector3.zero;

        if (joystick.inputDirection.x != 0 && joystick.inputDirection.z != 0)
        {
            move.x = joystick.inputDirection.x;
            move.z = joystick.inputDirection.z;
        }
        else
        {
            move.x = Input.GetAxis("Horizontal");
            move.z = Input.GetAxis("Vertical");
        }
        

        if (move.magnitude>1)
        {
            move.Normalize();
        }
        Vector3 rotatedMovement = camTransform.TransformDirection(move);
        rotatedMovement = new Vector3(rotatedMovement.x, 0, rotatedMovement.z);
        //Debug.Log("Virtual Joystick = " + move);

        rotatedMovement = rotatedMovement.normalized * move.magnitude;



        controller.AddForce(rotatedMovement * moveSpeed);
    }
}
