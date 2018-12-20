using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinceTournanteScript : MonoBehaviour {

    bool isGrabbed;
    float initialPos;
    public Transform controlerRight;

    private void Start()
    {
    }

    private void Update()
    {
        if (isGrabbed)
        {
            Vector3 temp = transform.eulerAngles;
            transform.LookAt(controlerRight);
            temp.y = transform.eulerAngles.y;
            transform.eulerAngles = temp;
        }
        if (!controlerRight.GetComponent<SteamVR_TrackedController>().padPressed)
        {
            isGrabbed = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "manette")
        {
            if (controlerRight.GetComponent<SteamVR_TrackedController>().padPressed)
            {
                isGrabbed = true;
            }
        }
    }
}
