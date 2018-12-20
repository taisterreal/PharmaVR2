using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OXyGaz_checker : MonoBehaviour {

    public GameObject vanne1;
    public GameObject vanne2;
    public GameObject vanne3;
    public GameObject vanne4;
    public Button bouton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (vanne1.GetComponent<VanneManager>().ouvert == true && vanne2.GetComponent<VanneManager>().ouvert == true && vanne3.GetComponent<VanneManager>().ouvert == true && vanne4.GetComponent<VanneManager>().ouvert == true)
        {
            bouton.image.color = Color.green;
        }
	}
}
