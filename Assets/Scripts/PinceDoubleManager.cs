using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinceDoubleManager : MonoBehaviour
{
    private Animator anim;
    public bool moving = false;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
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

    public void demarragePinceDouble()
    {
        moving = true;
    }
    public void arretPinceDouble()
    {
        moving = false;
    }
}
