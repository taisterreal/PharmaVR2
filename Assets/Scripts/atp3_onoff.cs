using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atp3_onoff : MonoBehaviour
{

    public bool active = true;
    bool arret = true;
    public GameObject arret_urgence;

    void Start()
    {

    }

    //pour test
    void Update()
    {
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            arret = arret_urgence.GetComponent<AR_etp3>().marche;
            if (arret == true)
            {

            }
            else
            {
                if (active == false)
                {
                    gameObject.transform.rotation = Quaternion.Euler(0, 180, 130);
                    active = true;
                }
                else if (active == true)
                {
                    gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                    active = false;
                }
            }
        }
    }
}
