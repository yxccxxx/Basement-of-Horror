using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using VRTK;

public class OculusTrigger : MonoBehaviour {
    public static bool touched1;
    public static bool touched2;
    public GameObject anim2;
    public GameObject box;
    private bool initialGrab = true;
	// Use this for initialization
	void Start () {
        touched1 = false;
        touched2 = false;
        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
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

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        if (initialGrab)
        {
            Debug.Log("INITIAL GRAB");
            initialGrab = false;
            anim2.GetComponent<PlayableDirector>().Play();
        }

    }
}
