using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pincedisabled : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("Pince_machiniste").SetActive(false);
        GameObject.Find("Boulette").SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
