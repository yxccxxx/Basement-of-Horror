using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class Animation1Start : MonoBehaviour {
    public GameObject go;
    private bool initial = true;
    // Update is called once per frame
    void Update () {
        bool touched = OculusTrigger.touched;
        if (touched && initial)
        {
            initial = false;
            go.GetComponent<PlayableDirector>().Play();
        }
	}
}
