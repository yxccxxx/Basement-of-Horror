using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Animation2Start : MonoBehaviour {
    public GameObject go;
    public GameObject keyboard;
    private bool initial = true;
	
	// Update is called once per frame
	void Update () {

        bool touched = customTouch.touchKeyBD;
       // Debug.Log(touched);
        if (touched && initial)
        {
            initial = false;
            keyboard.SetActive(false);
            go.GetComponent<PlayableDirector>().Play();
        }
	}
}
