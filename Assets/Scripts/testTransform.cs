using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testTransform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "manette")
        {

            Vector3 pos = transform.position;
            pos.z += 1;
            transform.position = pos;
            //gameObject.transform.position += new Vector3(0, 0, 1);
            Debug.Log("enclenché");
            //anim.Play("bouton haut vers bas");
        }
    }
}
