
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control2 : MonoBehaviour {
    bool ready;
	// Use this for initialization
	void Start () {
        ready = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!arTracked.visible && ready)
        {
            Debug.Log("okkkk");
            naga.state = 2;
            ready = false;
        }
        else if (arTracked.visible)
        {
            Debug.Log("sad");
            ready = true;
        }
    }
}
