using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuSceneLoader : MonoBehaviour {

    public bool VRMode;

    private const int menu = 0;
    private const int test = 1;

    void Start()
    {
        Debug.Log("START VR MODE = " + VRMode);
        // Unity Style Singleton so that the class doesnt get destroyed and reload a new
        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    void OnDestroy()
    {
        Debug.Log("Sccene Loader Was Destroyed");
    }


    public void VRModeYes()
    {
        VRMode = true;
        changeScene(test);
        Debug.Log("VR MODE = " + VRMode);
    }

    public void VRModeNo()
    {
        VRMode = false;
        changeScene(test);
        Debug.Log("VR MODE = " + VRMode);
    }

    public void changeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
