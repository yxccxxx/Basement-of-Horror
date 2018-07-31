using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusTrigger : MonoBehaviour {
    public static bool touched;
    public GameObject box;
	// Use this for initialization
	void Start () {
        touched = false;
	}
	
	// Update is called once per frame
	void Update () {
  
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals(box.name))
        {

            touched = true;
        }

    }
}
