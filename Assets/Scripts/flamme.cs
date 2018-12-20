using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flamme : MonoBehaviour
{
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    public bool active = false;

    public GameObject FLAMMES;

    void Start()
    {
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "boulette")
        {
            FLAMMES.SetActive(true);
            active = !active;
        }
    }
}
