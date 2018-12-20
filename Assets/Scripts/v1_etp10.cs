using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class v1_etp10 : MonoBehaviour
{
    public bool marche = false;
    public Material vert_pomme;
    public Material vert_eteint;

    // Use this for initialization
    void Start()
    {
        marche = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            if (marche == false && GameObject.Find("ar10").GetComponent<AR_etp10>().marche == false)
            {
                transform.position -= transform.forward * 0.01f;
                gameObject.GetComponent<Renderer>().material = vert_pomme;
                marche = true;
            }

            else if (marche == true)
            {
                transform.position += transform.forward * 0.01f;
                gameObject.GetComponent<Renderer>().material = vert_eteint;
                marche = false;
            }
        }
    }
}
