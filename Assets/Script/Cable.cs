using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour {

    public LineRenderer [] cable;

    public GameObject startPoint;
    public GameObject endPoint;

    Vector3[] posStartPoint;
    Vector3[] posEndPoint;

    

    // Use this for initialization
    void Start () {

       // cable = new Vector3[2];

        posStartPoint = new Vector3[1];
        posEndPoint = new Vector3[1];

        posStartPoint[0] = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z);
        posEndPoint[0] = new Vector3(endPoint.transform.position.x, endPoint.transform.position.y, endPoint.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {

        cable[0].GetComponent<LineRenderer>().SetPositions(posStartPoint);
        cable[1].GetComponent<LineRenderer>().SetPositions(posEndPoint);

        /*cable.setPosition(0, startPoint);
        cable.setPosition(1, endPoint);*/
    }
}
