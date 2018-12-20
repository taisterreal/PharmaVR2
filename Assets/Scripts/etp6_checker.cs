using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class etp6_checker : MonoBehaviour {

    public GameObject pince1;
    public GameObject pince2;

    public Material mat;
    public Material mat2;

    public bool etape6_fini;
	// Use this for initialization
	void Start () {
        etape6_fini = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (pince1.GetComponent<pinc1_checker>().pincebienmise == true && pince2.GetComponent<pinc2checker>().pincebienmise == true)
        {
            etape6_fini = true;
        }
        else
        {
            etape6_fini = false;
        }
	}
}
