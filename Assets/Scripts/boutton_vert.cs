using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boutton_vert : MonoBehaviour
{
    public GameObject bouton_vert;
    public Material actif;
    public Material inactif;
    //[SerializeField]
    public bool marche = false;
    public GameObject controller_droite;

    bool padPressedDown = false;
    bool padPreviousState = false;


    bool arret = true;
    public GameObject arret_urgence;

    void Start()
    {
        GetComponent<Renderer>().material = inactif;
        //GetComponent<Material>() = inactif;
    }

    //pour test
    void Update()
    {
        if (controller_droite.GetComponent<SteamVR_TrackedController>().padPressed && padPreviousState == false)
        {
            padPressedDown = true;
        }
        else
        {
            padPressedDown = false;
        }
        padPreviousState = controller_droite.GetComponent<SteamVR_TrackedController>().padPressed;

        if (arret_urgence.GetComponent<bouton_urgence>().marche == true)
        {
            marche = false;
            GetComponent<Renderer>().material = inactif;
        }
    }

    public void OnTriggerStay(Collider col)
    {
        if (col.tag == "manette")
        {
            if (padPressedDown)
            {
                arret = arret_urgence.GetComponent<bouton_urgence>().marche;
                if (arret == true)
                {

                }
                else
                {
                    if (marche)
                    {
                        GetComponent<Renderer>().material = inactif;
                        marche = false;
                    }

                    else if (marche == false)
                    {
                        GetComponent<Renderer>().material = actif;
                        marche = true;
                    }
                }
            }
        }
    }
}
