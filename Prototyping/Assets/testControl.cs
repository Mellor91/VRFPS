using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class testControl : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            transform.Rotate(transform.rotation.eulerAngles + new Vector3(0f,0.1f,0f));
        }

        float hj = Input.GetAxis("Horizontal");
        float vj = Input.GetAxis("Vertical");
        transform.position += new Vector3(hj*0.1f, vj*0.1f, 0f);

        float hm = Input.GetAxis("Mouse X");
        float vm = Input.GetAxis("Mouse Y");
        transform.position += new Vector3(hm * 0.1f, vm * 0.1f, 0f);
    }
}
