using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attrape_boulette : MonoBehaviour {

    public GameObject position_boulette;
    public GameObject bfire;

    // Use this for initialization
    void Update () {
        GameObject.Find("Boulette").transform.position = position_boulette.transform.position;
        bfire.SetActive(true);
        //bfire.transform.position = position_boulette.transform.position;
    }

}
