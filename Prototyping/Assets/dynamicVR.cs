﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class dynamicVR : MonoBehaviour {
    private bool VRMode = false;


	// Use this for initialization
	void Start () {
        GameObject sm = GameObject.Find("SceneManager");
        if(sm == null)
        {
            Debug.LogError("Unable to find Scene Manager");
        }
        menuSceneLoader msl = sm.GetComponent<menuSceneLoader>();
         
        GvrViewer.Instance.VRModeEnabled = msl.VRMode;
    }

    // Update is called once per frame
    void Update () {
       
    }
}
