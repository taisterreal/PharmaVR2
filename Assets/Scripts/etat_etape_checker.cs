using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class etat_etape_checker : MonoBehaviour {

    public Button bouton;
    public GameObject flamme_manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flamme_manager.GetComponent<flammeManager>().action_fini == true)
        {
            bouton.image.color = Color.green;
        }
	}
}
