using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanneManager : MonoBehaviour
{
    public bool ouvert = false;
    public GameObject controller_droite;
    bool padPressedDown = false;
    bool padPreviousState = false;

    void Start()
    {

    }

    private void Update()
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
    }


    public void OnTriggerStay(Collider col)
    {
        if (col.tag == "manette")
        {
            if (padPressedDown)
            {
                if (ouvert)
                {
                    gameObject.transform.rotation *= Quaternion.AngleAxis(-90, Vector3.forward);
                    ouvert = false;
                }
                else
                {
                    gameObject.transform.rotation *= Quaternion.AngleAxis(+90, Vector3.forward);
                    ouvert = true;
                }
            }

            
            /*else if (controller_droite.GetComponent<SteamVR_TrackedController>().triggerPressed == true && ouvert== false)
            {
                gameObject.transform.rotation *= Quaternion.AngleAxis(90, Vector3.forward);
                ouvert = true;
            }*/
        }
    }
}
