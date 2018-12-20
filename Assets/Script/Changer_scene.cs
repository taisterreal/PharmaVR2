using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Changer_scene : MonoBehaviour {

    Dropdown m_Dropdown;

    // Use this for initialization
    void Start () {
        m_Dropdown = GetComponent<Dropdown>();

        Debug.Log(m_Dropdown.value);

        /* m_Dropdown.onValueChanged.AddListener(delegate {
             SceneManager.LoadScene(1);
         });*/
    }
	
	// Update is called once per frame
	void Update () {
       

       
        if ( m_Dropdown.value== 1)
        {
            SceneManager.LoadScene(1);
        }


    }   
}
