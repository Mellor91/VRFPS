using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMotor : MonoBehaviour {

    public Transform attachedTo;
    private Vector3 offset;
    private float distance = 0f;
    private float yOffset = 1f;

	// Use this for initialization
	void Start ()
    {
        offset = new Vector3(0, yOffset, -1f * distance);	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = attachedTo.position + offset;    	
	}

    private void transformCamera(bool left)
    {
       // if(left) 
    }
}
