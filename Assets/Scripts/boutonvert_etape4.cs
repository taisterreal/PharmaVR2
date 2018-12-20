using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boutonvert_etape4 : MonoBehaviour
{
    public bool marche = false;
    public Material vert_pomme;
    public Material vert_eteint;
    public Button etape;


    // Use this for initialization
    void Start()
    {
        marche = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<boutonvert_etape4>().marche == true && GameObject.Find("urge bouton").GetComponent<urgence_etape4>().marche == false)
        {
            etape.image.color = Color.green;
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            if (marche == false && GameObject.Find("urge bouton").GetComponent<urgence_etape4>().marche == false)
            {
                transform.position += transform.forward * 0.01f;
                gameObject.GetComponent<Renderer>().material = vert_pomme;
                marche = true;
            }

            else if (marche == true)
            {
                transform.position -= transform.forward * 0.01f;
                gameObject.GetComponent<Renderer>().material = vert_eteint;
                marche = false;
            }
        }
    }
}
