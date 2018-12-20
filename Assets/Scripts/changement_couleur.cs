using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    [RequireComponent(typeof(Interactable))]
    public class changement_couleur : MonoBehaviour
    {

        public GameObject bouton;
        Material m_Material;

        public Material mat_brillant;

        public AudioSource bruit_bouton;
        
        bool active;
        // Use this for initialization
        void Start()
        {
            active = false;
            m_Material = bouton.GetComponent<Renderer>().material;
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

                bouton.GetComponent<Renderer>().material = mat_brillant;

                //m_Material. = mat_brillant;

                Debug.Log(" bool = true");

                bruit_bouton.Play();

                active = true;
            }

            else if (hand.GetStandardInteractionButtonDown() && active == true)
            {
                hand.HoverLock(GetComponent<Interactable>());

                bouton.GetComponent<Renderer>().material = m_Material;
                //m_Material = mat_brillant;
                Debug.Log(" bool = false");
                active = false;

                bruit_bouton.Play();
            }

            if (hand.GetStandardInteractionButtonUp())
            {

                hand.HoverUnlock(GetComponent<Interactable>());


            }
        }
    }
}