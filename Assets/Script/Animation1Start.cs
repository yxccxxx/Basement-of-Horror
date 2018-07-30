using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1Start : MonoBehaviour {
    public GameObject door;
    // Update is called once per frame
    void Update () {
        bool touched = OculusTrigger.touched;
        if (touched)
        {
            Debug.Log("touched!!!!!!");
            // animation begins from here
            Animator anim = door.GetComponent<Animator>();
            anim.Play("front-door-pivot");
        }
	}
}
