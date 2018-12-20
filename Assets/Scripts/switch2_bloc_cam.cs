using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switch2_bloc_cam : MonoBehaviour
{
    public Animator anim;
    public bool active = false;

    public GameObject arret_urgence;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //pour test
    void Update()
    {

        /*if (Input.GetKeyDown("c"))
        {
            anim.Play("switchon");
        }
        if (Input.GetKeyDown("v"))
        {
            anim.Play("switchoff");
        }*/
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            if (active == false)
            {
                anim.Play("s2_on");
                active = true;
            }

            else if (active == true)
            {
                anim.Play("s2_ontooff");
                active = false;
            }
        }
    }
}
