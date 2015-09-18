using UnityEngine;
using System.Collections;

public class OldUIScene2 : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {

		GUI.Label (new Rect (250, 70, 100, 20), "This is Scene 2");
		if (GUI.Button (new Rect (250, 100, 100, 25), "Go to Scene 1"))
			Application.LoadLevel ("Scene 1");

		#if CLOUD_BUILD

			GUI.Label(new Rect(10,10,225,20), "This ad has been brought to you by the people at CloudBuild.");

		#endif

		#if SCRIPT_DEFINE_TEST

			GUI.Label(new Rect(10,40,225,20), "Custom script define named SCRIPT_DEFINE_TEST fired.");
		
		#endif

		#if UNITY_IOS

			GUI.Label(new Rect(10,60,225,20), "This is an iOS build.");
		
		#endif

		#if UNITY_ANDROID

			GUI.Label(new Rect(10,60,225,20), "This is an Android build.");

		#endif

		#if UNITY_WEBPLAYER

			GUI.Label(new Rect(10,60,225,20), "This is a Webplayer build.");
		
		#endif

		#if UNITY_SAMSUNGTV
		
		GUI.Label(new Rect(10,60,225,20), "This is an STV build.");
		
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
