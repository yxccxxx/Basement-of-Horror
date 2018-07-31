using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Keyboard")
        {
            Destroy(other.gameObject);
        }
    }
}
