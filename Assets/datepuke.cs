using UnityEngine;
using System.Collections;
using System;

public class datepuke : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {

		GUI.Label (new Rect (10, 10, 100, 10), DateTime.Now.ToString());

	}
}
