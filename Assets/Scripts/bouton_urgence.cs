using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class bouton_urgence : MonoBehaviour
{
    public GameObject controller_droite;

    bool padPressedDown = false;
    bool padPreviousState = false;
    
    public bool marche;

    void Start()
    {
        marche = true;
    }

    private void Update()
    {
        if(controller_droite.GetComponent<SteamVR_TrackedController>().padPressed && padPreviousState == false)
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
                if (marche == false)
                {
                    transform.position -= transform.forward * 0.02f;
                    marche = true;
                }

                else if (marche == true)
                {
                    transform.position += transform.forward * 0.02f;
                    marche = false;
                }
            }
        }
    }
}
