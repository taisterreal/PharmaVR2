using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class Cuve_mise_en_place : MonoBehaviour
    {
        GameObject check_cuve;

        public GameObject cuve2;
        // Use this for initialization
        void Start()
        {
            check_cuve = GameObject.Find("Mise en place de la cuve produit sur le LAF");
            cuve2.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.CompareTag("machine_trigger"))
            {
                Debug.Log("Cuve mis!");

                //gameObject.transform.position = new Vector3(-2.001f, 1.045f, 0.97f);

                //gameObject.SetActive(false);
                //Destroy(gameObject);
                gameObject.transform.position = new Vector3(100f, 100f, 100f);
                cuve2.SetActive(true);

                check_cuve.GetComponent<Toggle>().isOn = true;

                //gameObject.GetComponent<InteractableExample>().enabled = false;


                //gameObject.GetComponent<Rigidbody>().useGravity = false;
            }


        }
    }
}