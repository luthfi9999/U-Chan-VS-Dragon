using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    bool ready;
	// Use this for initialization
	void Start () {
        ready = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!ARTrackedObject.visible&&ready)
        {
            uchan.state = 0;
            ready = false;
        }
        else if (ARTrackedObject.visible)
        {
            ready = true;
        }
	}
}
