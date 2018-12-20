using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_urgence_etape3 : MonoBehaviour
{

    public bool marche;

    void Start()
    {
        marche = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "manette")
        {
            if (marche == false)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 180, 130);
                marche = true;
            }

            else if (marche == true)
            {
                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                marche = false;
            }
        }
    }

}
