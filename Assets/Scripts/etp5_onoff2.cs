using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class etp5_onoff2 : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

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
        if (arret_urgence.GetComponent<AR_etp5>().marche == true)
        {
            active = false;
            anim.Play("s2_off");
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            arret = arret_urgence.GetComponent<AR_etp5>().marche;
            if (arret == true)
            {

            }
            else
            {
                if (active == false)
                {
                    anim.Play("s2_on");
                    active = true;
                }

                else if (active == true)
                {
                    anim.Play("s2_ontooff");
                    active = false;
                }
            }
        }
    }
}
