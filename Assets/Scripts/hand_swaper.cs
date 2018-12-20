using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_swaper : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.GetComponent<SteamVR_TrackedController>().padPressed == true)
        {
            GameObject.Find("hand_ready_R").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("Right Hand").GetComponent<MeshRenderer>().enabled = false;
        }
        else
        {
            GameObject.Find("hand_ready_R").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Right Hand").GetComponent<MeshRenderer>().enabled = true;
        }
	}
}
