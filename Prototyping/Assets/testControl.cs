using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class testControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
    //    GvrViewer.Instance.VRModeEnabled = false;
    }
	
	// Update is called once per frame
	void Update () {

        VRSettings.enabled = false;
        if (Input.GetButtonDown("Fire1"))
        {
            transform.Rotate(transform.rotation.eulerAngles + new Vector3(0f,0.1f,0f));
        }

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        transform.position += new Vector3(h*0.1f, v*0.1f, 0f);
	}
}
