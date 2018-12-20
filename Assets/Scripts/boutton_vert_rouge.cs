using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boutton_vert_rouge : MonoBehaviour
{
    public GameObject bouton_vert;
    public GameObject bouton_rouge;
    public GameObject bouton_blanc;
    public Animator animvert;
    public Animator animrouge;
    Material actuel;
    public GameObject controller_droite;
    bool padPressedDown = false;
    bool padPreviousState = false;

    //[SerializeField]
    public bool marche = false;

    bool arret = true;
    public GameObject arret_urgence;

    void Start()
    {
        animvert = bouton_vert.GetComponent<Animator>();
        animrouge = bouton_rouge.GetComponent<Animator>();
        actuel = bouton_blanc.GetComponent<Renderer>().material;
        actuel.color = Color.black;
    }

    //pour test
    void Update()
    {
        if (arret_urgence.GetComponent<bouton_urgence>().marche == true)
        {
            marche = false;
            actuel.color = Color.black;
        }

        if (controller_droite.GetComponent<SteamVR_TrackedController>().padPressed && padPreviousState == false)
        {
            padPressedDown = true;
        }
        else
        {
            padPressedDown = false;
        }
        padPreviousState = controller_droite.GetComponent<SteamVR_TrackedController>().padPressed;
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
                    if (marche == false)
                    {
                        animvert.Play("pression");
                        actuel.color = Color.white;
                        marche = true;
                    }

                    else if (marche == true)
                    {
                        animrouge.Play("pression_red");
                        actuel.color = Color.black;
                        marche = false;
                    }
                }
            }
        }
    }
}
