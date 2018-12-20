using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    [RequireComponent(typeof(Interactable))]
    public class InteracableBoutonCliquable : MonoBehaviour {

    bool active;

    public AudioSource bruit_bouton;

    //Vector3 pos1, pos2;
    //Quaternion rot1, rot2;
    // Use this for initialization
        void Start()
    {
        active = false;

        /* pos1 = new Vector3(23.6f, -21.8179f, -21.12922f);
         rot1 = new Quaternion(18.57f, -43.118f, 44.878f, 0);

         pos2 = new Vector3(8.63f, 19.56f, 17.53f);
         rot2 = new Quaternion(12.736f, 30.419f, -35.648f, 0);*/

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void HandHoverUpdate(Hand hand)
    {
        if (hand.GetStandardInteractionButtonDown() && active == false)
        {
            hand.HoverLock(GetComponent<Interactable>());

            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 0.2f);
            /*transform.localPosition = pos2;
            transform.localRotation = rot2;*/

            active = true;

            bruit_bouton.Play();

            Debug.Log("bouton activé");
        }

        else if (hand.GetStandardInteractionButtonDown() && active == true)
        {
            hand.HoverLock(GetComponent<Interactable>());

                transform.localPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
                /*transform.localPosition = pos1;
                transform.localRotation = rot1;*/
                active = false;

                bruit_bouton.Play();

            Debug.Log("bouton desactivé");
        }

        if (hand.GetStandardInteractionButtonUp())
        {

            hand.HoverUnlock(GetComponent<Interactable>());


        }

    }
}
}
