using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uchan : MonoBehaviour {
    public static int state;
    public Animator anim;
	// Use this for initialization
	void Start () {
        state = 2;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (state == 0)
        {
            anim.Play("ScrewKick", -1, 0f);
            naga.state = 0;
            state = 2;
        }
        else if (state == 1)
        {
            anim.Play("DamageDown", -1, 0f);
            //naga.state = 2;
            state = 2;
        }
    }
}
