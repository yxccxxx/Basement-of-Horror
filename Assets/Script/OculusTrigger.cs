using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusTrigger : MonoBehaviour {
    public static bool touched1;
    public static bool touched2;
    public GameObject box;
	// Use this for initialization
	void Start () {
        touched1 = false;
        touched2 = false;
	}
	
	// Update is called once per frame
	void Update () {
  
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals(box.name) && gameObject.name.Equals("OculusRift"))
        {

            touched1 = true;
        }

        if (other.gameObject.name.Equals(box.name) && gameObject.name.Equals("OculusLeftController"))
        {

            touched2 = true;
        }

        if (other.gameObject.name.Equals(box.name) && gameObject.name.Equals("OculusRightController"))
        {

            touched2 = true;
        }

    }
}
