using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bout_urg_etape3 : MonoBehaviour {
    public bool marche = false;
    // Use this for initialization
    void Start () {
        marche = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {
            if (marche == false)
            {
                transform.position -= transform.forward * 0.02f;
                marche = true;
            }

            else if (marche == true)
            {
                transform.position += transform.forward * 0.02f;
                marche = false;
            }
        }
    }
}
