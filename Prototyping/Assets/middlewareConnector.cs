using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class middlewareConnector : MonoBehaviour {

    private const string URL = "http://localhost/vrfpsMiddleware/middleware/Middleware.php?authenticateUser&";
    private List<KeyValuePair<string, string>> kvpURLAttributes = new List<KeyValuePair<string, string>>();
    private WebClient client = new WebClient();
    private string urlEnd;

    //authenticateUser&email=james@mellor&password=pass

    public Text output;
    public InputField username;
    public InputField password;


    // Use this for initialization
    void Start () {

        
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void onSubmitClicked()
    {
        if(!validate())
        {
            return;
        }
        Debug.Log("URL String = " + URL + urlEnd);
        var json = client.DownloadString(URL+urlEnd);
        Debug.Log("json string = " + json);
        output.text = json.ToString();


        //Build the key value pairs as string
    }

    bool validate()
    {
        if(username.text != "" && password.text != "")
        {
           // kvpURLAttributes.Insert(0, new KeyValuePair<string, string>("email=", username.text));
            //kvpURLAttributes.Insert(0, new KeyValuePair<string, string>("&password=", password.text));
            urlEnd = "email=" + username.text + "&password=" + password.text;
            return true;
        }
        else
        {
            output.text = "you have not supplied a username and password";
        }
        Debug.Log("username = " + username.text);
        return false;
    }
}
