using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class etp10_checker : MonoBehaviour {

    public Button step10;
    public GameObject bouton1;
    public GameObject bouton2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(bouton1.GetComponent<v1_etp10>().marche == true && bouton2.GetComponent<v1_etp10>().marche == true)
        {
            step10.image.color = Color.green;
        }
	}
}
