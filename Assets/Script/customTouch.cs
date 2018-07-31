using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customTouch : MonoBehaviour {
    public static bool touchKeyBD = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Keyboard"){
            touchKeyBD = true;

        }
        Debug.Log(other.name);
    }
}
