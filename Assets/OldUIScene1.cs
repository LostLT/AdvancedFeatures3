using UnityEngine;
using System.Collections;

public class OldUIScene1 : MonoBehaviour {

	void Start() {

		string CompanyName = "Company Name: " + Application.companyName;
		string ProductName = "Product Name: " + Application.productName;
		string CloudProjID = "Cloud ProjID: " + Application.cloudProjectId;
		string Platform = "Platform: " + Application.platform;
		string MACaddy = "MAC Address: " + SystemInfo.deviceUniqueIdentifier;
		string BundleID = "Bundle ID: " + Application.bundleIdentifier;
		string BundleVer = "Bundle Ver: " + Application.version;

		Debug.Log (BundleID);
		Debug.Log (BundleVer);
		Debug.Log (CompanyName);
		Debug.Log (ProductName);
		Debug.Log (CloudProjID);
		Debug.Log (Platform);
		Debug.Log (MACaddy);
		
	}

	/*string PassVariables(string ProtectedVar) {

		if (ProtectedVar == "BundleID")
			return Application.bundleIdentifier;
		else
			return "UNK ERROR";
		//elseif





			//	else ProtectedVar = "UNK ERROR";


	}
	*/
	
	// Use this for initialization
	void OnGUI () {

		string CompanyName = "Company Name: " + Application.companyName;
		string ProductName = "Product Name: " + Application.productName;
		string CloudProjID = "Cloud ProjID: " + Application.cloudProjectId;
		string Platform = "Platform: " + Application.platform;
		string MACaddy = "MAC Address: " + SystemInfo.deviceUniqueIdentifier;
		string BundleID = "Bundle ID: " + Application.bundleIdentifier;
		string BundleVer = "Bundle Ver: " + Application.version;
		
		GUI.Label (new Rect (250, 70, 100, 20), "This is Scene 1");
		if (GUI.Button (new Rect (250, 100, 100, 25), "Go to Scene 2"))
			Application.LoadLevel ("Scene 2");

		GUI.Label (new Rect(500, 10, 250, 20), BundleID);
		GUI.Label (new Rect (500, 40, 250, 20), BundleVer);
		GUI.Label (new Rect (500, 70, 250, 20), CompanyName);
		GUI.Label (new Rect (500, 100, 250, 20), ProductName);
		GUI.Label (new Rect (500, 130, 250, 20), CloudProjID);
		GUI.Label (new Rect (500, 160, 250, 20), Platform);
		GUI.Label (new Rect (500, 190, 250, 20), MACaddy);

		#if CLOUD_BUILD

			GUI.Label(new Rect(10,10,225,20), "This ad has been brought to you by the people at CloudBuild.");

		#endif

		#if SCRIPT_DEFINE_TEST

			GUI.Label(new Rect(10,100,325,20), "You have defined SCRIPT_DEFINE_TEST to fire.");
		
		#endif
		
		#if UNITY_IOS

			GUI.Label(new Rect(10,60,225,20), "This is an iOS build.");
		
		#endif

		#if UNITY_ANDROID

			GUI.Label(new Rect(10,80,225,20), "This is an Android build.");

		#endif

		#if UNITY_WEBPLAYER

			GUI.Label(new Rect(10,100,225,20), "This is a Webplayer build.");
		
		#endif

		#if UNITY_SAMSUNGTV
		
		GUI.Label(new Rect(10,60,225,20), "This is an STV build.");
		GUI.Label (new Rect(10,90,225,25), "You will have to check Player Settings manually");
		GUI.Label (new Rect(10,120,225,25), "Some stuff is in manifest.xml");
		GUI.Label (new Rect(10,120,225,25), "Other stuff is in other places");

		#endif
		
		#if UNITY_BLACKBERRY
		
		GUI.Label(new Rect(10,60,225,20), "This is a BlackBerry build.");
		
		#endif
		
		#if UNITY_TIZEN
		
		GUI.Label(new Rect(10,60,225,20), "This is a Tizen build.");
		
		#endif


	
	}

	
	// Update is called once per frame
	void Update () {

			
	
	}
}
