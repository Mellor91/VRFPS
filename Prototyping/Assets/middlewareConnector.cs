using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class middlewareConnector : MonoBehaviour {

    private const string URL = "http://localhost/vrfps/middleware/DatabaseConnector.php";
    private List<KeyValuePair<string, string>> kvpURLAttributes = new List<KeyValuePair<string, string>>();
    private WebClient client = new WebClient();

    public Text output;
    // Use this for initialization
    void Start () {
        var json = client.DownloadString(URL);
        Debug.Log("json string = " + json);
        output.text = json.ToString();
        
    }
	
	// Update is called once per frame
	void Update () {
		
        // if the submit button is clicked pass the values

	}






    void onSubmitClicked()
    {
        validate();

        //Build the key value pairs as string
    }

    void validate()
    {

    }
}
