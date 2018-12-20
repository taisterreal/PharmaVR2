using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_position_boulette : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boulette")
        {
            gameObject.GetComponent<attrape_boulette>().enabled = true;
        }
    }

}
