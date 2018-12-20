using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bouton_on_off : MonoBehaviour
{


    //public Animator anim;
    public bool active = false;

    bool arret = true;
    public GameObject arret_urgence;
    public GameObject controller_droite;
    //bool padPressedDown = false;
    bool padPressedDown = false;
    bool padPreviousState = false;


    void Start()
    {
        //anim = GetComponent<Animator>();
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
        /*
        if (arret_urgence.GetComponent<bouton_urgence>().marche == true)
        {
            active = false;
            anim.Play("switchoff");
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            arret = arret_urgence.GetComponent<bouton_urgence>().marche;
            if (arret == true)
            {

            }
            else
            {
                if (active == false)
                {
                    anim.Play("switchon");
                    active = true;
                }

                else if (active == true)
                {
                    anim.Play("switchoff");
                    active = false;
                }
            }
        }*/

        if (arret_urgence.GetComponent<bouton_urgence>().marche == true)
        {
            if (active)
            {
                gameObject.transform.rotation *= Quaternion.AngleAxis(-90, Vector3.forward);
            }

            active = false;
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
                if (active)
                {
                    gameObject.transform.rotation *= Quaternion.AngleAxis(-90, Vector3.forward);
                    active = false;
                }
                else if (active == false)
                {
                    gameObject.transform.rotation *= Quaternion.AngleAxis(+90, Vector3.forward);
                    active = true;
                }
            }

        }
    }
}
