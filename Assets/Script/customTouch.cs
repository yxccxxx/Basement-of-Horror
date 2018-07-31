using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customTouch : MonoBehaviour {
    public static bool touchKeyBD;
	// Use this for initialization
	void Start () {
        touchKeyBD = false;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(touchKeyBD);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Equals("Keyboard")){
            touchKeyBD = true;

        }
        Debug.Log(other.gameObject.name);
    }
}
