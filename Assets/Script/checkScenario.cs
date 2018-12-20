using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class checkScenario : MonoBehaviour {

    GameObject _positionLevier;
    GameObject _positionRoue;
    GameObject _verificationVrai;
    public GameObject _Levier;
    public GameObject _Roue;


     void Start()
    {
        _positionLevier = GameObject.Find("Position Levier");
        _positionRoue = GameObject.Find("Rotation Plaque");
        _verificationVrai = GameObject.Find("verification_vrai");

        
        _verificationVrai.SetActive(false);
        }

    private void Update()
    {
        if (_Levier.transform.localPosition.x > 0.4)
            _positionLevier.GetComponent<Toggle>().isOn = true;

        if (_Levier.transform.localPosition.x < 0.4)
            _positionLevier.GetComponent<Toggle>().isOn = false;

        Debug.Log(_Roue.transform.localRotation.y);

        if (_Roue.transform.rotation.y > 0.9)
            _positionRoue.GetComponent<Toggle>().isOn = true;

        if (_Roue.transform.rotation.y < 0.9)
            _positionRoue.GetComponent<Toggle>().isOn = false;

    }


}
