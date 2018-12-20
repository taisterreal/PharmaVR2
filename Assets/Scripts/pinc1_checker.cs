using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinc1_checker : MonoBehaviour {
    public bool pincebienmise;
    public Material vert;
    public Material rouge;

    // Use this for initialization
    void Start () {
        pincebienmise = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pince1")
        {
            pincebienmise = true;
            GameObject.Find("pinceindicator").GetComponent<Renderer>().material = vert;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pince1")
        {
            pincebienmise = false;
            GameObject.Find("pinceindicator").GetComponent<Renderer>().material = rouge;
        }
    }
}
