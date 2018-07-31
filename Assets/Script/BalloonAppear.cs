using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonAppear : MonoBehaviour {
    public GameObject box;
    private bool initial;

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
        box.SetActive(false);
        initial = true;
	}
	
	// Update is called once per frame
	void Update () {
		bool KBDtouched = customTouch.touchKeyBD;

        // let the balloon and box appear when keyboard is touched
        if(KBDtouched && initial)
        {
            gameObject.SetActive(true);
            box.SetActive(true);
        }
    }
}
