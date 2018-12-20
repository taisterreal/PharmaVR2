using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerManager : MonoBehaviour
{

    //Tutoriel
    public GameObject tuto_placard;
    public GameObject tuto_pupitre;

    public GameObject arret_urgence;
    bool arret;
    //public Renderer rend_mano;
    bool pince_en_main = false;

    // Use this for initialization
    void Start () {
        //arret = arret_urgence.GetComponent<bouton_urgence>().marche;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //A REVOIR
        //if (Controller.GetHairTriggerDown())

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "pince")
        {
            col.transform.parent = transform;
            col.transform.position = transform.position;
            col.transform.rotation = transform.rotation;
            //rend_mano.enabled = false;
            pince_en_main = true;
        }

        if (col.tag == "placard")
        {
            tuto_placard.SetActive(true);
        }
        if (col.tag == "pupitre")
        {
            tuto_pupitre.SetActive(true);
        }
    }
 
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "placard")
        {
            tuto_placard.SetActive(false);
        }
        if (col.tag == "pupitre")
        {
            tuto_pupitre.SetActive(false);
        }
    }
}
