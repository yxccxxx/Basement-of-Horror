using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Animation2Start : MonoBehaviour {
    public GameObject go;
    private bool initial = true;
	
	// Update is called once per frame
	void Update () {

        bool touched = OculusTrigger.touched2;
       // Debug.Log(touched2);
        if (touched && initial)
        {
            initial = false;
            go.GetComponent<PlayableDirector>().Play();
        }
	}
}
