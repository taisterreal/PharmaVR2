using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class etp3_checker : MonoBehaviour {

    public Button etape;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("switch1").GetComponent<atp3_onoff>().active == true)
        {
            etape.image.color = Color.green;
        }
    }
}
