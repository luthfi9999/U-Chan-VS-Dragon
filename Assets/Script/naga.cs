using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naga : MonoBehaviour {
    public static int state;
    float speed = 0f;
    Vector3 a;
	// Use this for initialization
	void Start () {
        state = 4;
	}
	
	// Update is called once per frame
	void Update () {

        if (state == 0)
        {
            if (speed < 0.0011f)
            {
                Debug.Log("wah");
                speed += 0.001f * Time.deltaTime;
                a = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
                transform.position = a;
                //state = 1;
            }
            else
            {
                Debug.Log("ok");
                state = 1;
                speed = 0;
            }
        }
        else if (state == 1)
        {
            if (speed < 0.0011f)
            {
                Debug.Log("yo");
                speed += 0.001f * Time.deltaTime;
                a = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
                transform.position = a;
                //state = 1;
            }
            else
            {
                state = 4;
                speed = 0;
            }
        }
        else if (state == 2)
        {
            if (speed < 0.0011f)
            {
                Debug.Log("yo");
                speed += 0.001f * Time.deltaTime;
                a = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
                transform.position = a;
                //state = 1;
            }
            else
            {
                uchan.state = 1;
                state = 3;
                speed = 0;
            }
        }
        else if (state == 3)
        {
            if (speed < 0.0011f)
            {
                Debug.Log("yo");
                speed += 0.001f * Time.deltaTime;
                a = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
                transform.position = a;
                //state = 1;
            }
            else
            {
                state = 4;
                speed = 0;
            }
        }

    }
}
