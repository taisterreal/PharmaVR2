using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonChargement1Manager : MonoBehaviour
{
    public bool allume = false;
    public GameObject pinceTournante;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            if (allume)
            {
                Debug.Log("allumé");
                //changer texture
                allume = false;
                pinceTournante.GetComponent<PinceTournanteManager>().moving = false;
            }
            else
            {

                Debug.Log("éteint");
                //changer texture
                allume = true;
                pinceTournante.GetComponent<PinceTournanteManager>().moving = true;
            }
        }
    }
}
