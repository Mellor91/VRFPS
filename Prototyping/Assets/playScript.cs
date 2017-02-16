using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;



public class playScript : MonoBehaviour {

    public GameObject VRModeObj;
    public Button Play;


	// Use this for initialization
	void Start () {
       VRModeObj.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void playPressed()
    {
        VRModeObj.SetActive(true);
        Play.interactable = false;

    }
}
