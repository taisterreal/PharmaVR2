using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AR_U_Cam : MonoBehaviour
{
    public Animator anim;
    public bool marche = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider col)
    {

        if (marche == false)
        {
            anim.Play("AR_U_bas_haut");
            marche = true;
        }

        else if (marche == true)
        {
            anim.Play("AR_U_haut_bas");
            marche = false;
        }
    }
}
