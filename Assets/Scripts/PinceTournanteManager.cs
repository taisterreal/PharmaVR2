using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinceTournanteManager : MonoBehaviour
{
    private Animator anim;
    public bool moving = false;

        // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

	// Update is called once per frame
	void Update ()
    {
        if (moving)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
    }

    public void demarragePinceTournante()
    {
        moving = true;
    }
    public void arretPinceTournante()
    {
        moving = false;
    }


}
