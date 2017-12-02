using UnityEngine;
using System.Collections;

public class screenshotButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Screenshot() {
		Application.CaptureScreenshot("Capture.png");
	}
}
