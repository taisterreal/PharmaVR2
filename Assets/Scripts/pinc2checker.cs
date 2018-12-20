using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinc2checker : MonoBehaviour {
    public bool pincebienmise;
    public Material vert;
    public Material rouge;

    // Use this for initialization
    void Start()
    {
        pincebienmise = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pince2")
        {
            pincebienmise = true;
            GameObject.Find("pinceindicator2").GetComponent<Renderer>().material = vert;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pince2")
        {
            pincebienmise = false;
            GameObject.Find("pinceindicator2").GetComponent<Renderer>().material = rouge;
        }
    }
}
