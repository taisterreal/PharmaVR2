using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class Raccordement_Pression : MonoBehaviour
    {

        GameObject raccordement_cable;
        GameObject raccordement_cable_mis;

        GameObject raccordement_machine;
        GameObject raccordement_machine_mis;

        GameObject joint_cable;
        GameObject joint_cable_mis;

        GameObject cable;

        public GameObject cable2;

        public AudioSource bruit;

        GameObject check_cable_pression;

        // Use this for initialization
        void Start()
        {
            check_cable_pression = GameObject.Find("Raccordement sur la buse de pulvérisation");

            raccordement_cable = GameObject.Find("Raccordement prise de pression");
            raccordement_cable_mis = GameObject.Find("Raccordement prise de pression Mis 2");


            joint_cable_mis = GameObject.Find("Point cable (1)");
            joint_cable = GameObject.Find("Point cable");


            cable = GameObject.Find("Cable pression");            
            //cable2 = GameObject.Find("Cable pression (1)");            


            raccordement_machine = GameObject.Find("Raccordement prise de pression (2)");
            raccordement_machine_mis = GameObject.Find("Raccordement prise de pression Mis");


            raccordement_machine_mis.SetActive(false);
            raccordement_cable_mis.SetActive(false);
            joint_cable_mis.SetActive(false);

            cable2.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider col)
        {
            
            //col = raccordement_cable.GetComponent < Collider >();
            if (col.gameObject.CompareTag("raccordement_machine"))
            {
                Debug.Log("Cable pression mis!");

                /*gameObject.GetComponent<InteractableExample>().enabled = false;
                gameObject.GetComponent<CapsuleCollider>().enabled = !raccordement_cable.GetComponent<BoxCollider>();
                gameObject.GetComponent<Interactable>().enabled = false;*/

                raccordement_machine_mis.SetActive(true);
                raccordement_cable_mis.SetActive(true);
                joint_cable_mis.SetActive(true);
                cable2.SetActive(true);

                bruit.Play();

                cable2.gameObject.SetActive(true);

                raccordement_cable.transform.position = raccordement_machine.transform.position;
                Debug.Log("cable activé");
                raccordement_cable.SetActive(false);
                raccordement_machine.SetActive(false);
                joint_cable.SetActive(false);
                cable.SetActive(false);


                check_cable_pression.GetComponent<Toggle>().isOn = true;



            }


        }
    }
}
