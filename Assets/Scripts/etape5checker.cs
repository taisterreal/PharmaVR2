using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class etape5checker : MonoBehaviour
{

    public GameObject swith1;
    public GameObject swith2;
    public Button bouton;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (swith1.GetComponent<etp5_onoff>().active == true && swith2.GetComponent<etp5_onoff2>().active == true)
        {
            bouton.image.color = Color.green;
        }

    }


}
