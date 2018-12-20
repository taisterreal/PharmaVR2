using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camerabloc : MonoBehaviour
{
    public Animator anim;
    public bool active = false;

    bool arret = true;
    public GameObject arret_urgence;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //pour test
    void Update()
    {
        if (arret_urgence.GetComponent<AR_U_Cam>().marche == true)
        {
            active = false;
            anim.Play("off_null");
        }

        /*if (Input.GetKeyDown("c"))
        {
            anim.Play("switchon");
        }
        if (Input.GetKeyDown("v"))
        {
            anim.Play("switchoff");
        }*/
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            arret = arret_urgence.GetComponent<AR_U_Cam>().marche;
            if (arret == true)
            {

            }
            else
            {
                if (active == false)
                {
                    anim.Play("mise en on");
                    active = true;
                }

                else if (active == true)
                {
                    anim.Play("mise en off");
                    active = false;
                }
            }
        }
    }
}
