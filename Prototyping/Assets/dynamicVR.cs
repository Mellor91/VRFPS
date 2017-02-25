using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class dynamicVR : MonoBehaviour {
    private bool VRMode = false;


	// Use this for initialization
	void Start () {
        GameObject sceneManager = GameObject.Find("SceneManager");
        if(sceneManager == null)
        {
            Debug.LogError("Unable to find Scene Manager");
        }
        //menuSceneLoader msl = sm.GetComponent<menuSceneLoader>();
         
        GvrViewer.Instance.VRModeEnabled = sceneManager.GetComponent<menuSceneLoader>().VRMode;
    }

    // Update is called once per frame
    void Update () {
       
    }
}
