using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{

    public class Fermeture_cuve : MonoBehaviour
    {

        public GameObject Switch;
        GameObject check_cuve_ferme;

       
        // Use this for initialization
        void Start()
        {
            check_cuve_ferme = GameObject.Find("Fermeture de la cuve");
           

        }

        // Update is called once per frame
        void Update()
        {
            if (Switch.gameObject.transform.localRotation.z > -0.3f)
            {
                Debug.Log(Switch.gameObject.transform.localRotation.z);
                Debug.Log("cuve fermée");
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>();
                gameObject.GetComponent<Rigidbody>().useGravity = false;
                gameObject.GetComponent<InteractableExample>().enabled = false;
                gameObject.GetComponent<Interactable>().enabled = false;


                check_cuve_ferme.GetComponent<Toggle>().isOn = true;
                

            }
        }

        void OnTriggerEnter(Collider col)
        {
            /* if (col.gameObject.CompareTag("machine_trigger"))
             {
                 Debug.Log("Cuve mis!");

                 gameObject.transform.position = new Vector3(-2.001f, 1.045f, 0.97f);

                 //gameObject.GetComponent<InteractableExample>().enabled = false;


                 gameObject.GetComponent<Rigidbody>().useGravity = false;
             }
             */

        }
    }

}
