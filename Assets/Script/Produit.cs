using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Valve.VR.InteractionSystem
{
    public class Produit : MonoBehaviour
    {

        GameObject check_produit;
        public GameObject produit;

        // Use this for initialization
        void Start()
        {
            check_produit = GameObject.Find("Introduction du produit dans la cuve");
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.CompareTag("cuve"))
            {
                Debug.Log("Produit mis!");

                produit.transform.position = new Vector3(100f, 100f, 100f);
                
                /*produit.GetComponent<InteractableExample>().enabled = false;

                produit.GetComponent<BoxCollider>().enabled = !produit.GetComponent<BoxCollider>(); 
                produit.GetComponent<Interactable>().enabled = false;
                produit.gameObject.SetActive(false);

                
                Destroy(produit.gameObject);*/

                check_produit.GetComponent<Toggle>().isOn = true;

            }


        }
    }
}