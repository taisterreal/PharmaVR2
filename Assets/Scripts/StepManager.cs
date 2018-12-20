using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Contrôle l'ouverture des vannes de l'armoire et indique à l'utilisateur si tout est ouvert

public class StepManager : MonoBehaviour
{
    public List<GameObject> Vannes;
    public List<GameObject> OnOffs;
    public List<GameObject> BoutonsDoubles;
    public List<GameObject> Boutons;
    public List<GameObject> Buses;
    public List<GameObject> Pince;
    //public List<GameObject> Urgences;
    //public GameObject check_armoire;
    public Scenario1Manager.Etat etat = Scenario1Manager.Etat.pasFait;
    //public TypeObjet.Type type;
    //public enum Type { Vanne, OnOff, Bouton };


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        etat = Scenario1Manager.Etat.pasFait;


        int vannecompteur = 0;

        if (Vannes.Count != 0)
        {
            int boutondoublecompteur = 0;

            if (Boutons.Count != 0)
            {
                foreach (GameObject BoutonDouble in BoutonsDoubles)
                {
                    if (BoutonDouble.GetComponent<boutton_vert_rouge>().marche)
                    {
                        etat = Scenario1Manager.Etat.enCours;
                        boutondoublecompteur += 1;
                    }
                    if (etat == Scenario1Manager.Etat.fini && !BoutonDouble.GetComponent<boutton_vert_rouge>().marche)
                    {
                        etat = Scenario1Manager.Etat.enCours;
                        boutondoublecompteur -= 1;
                    }
                    if (boutondoublecompteur == BoutonsDoubles.Count)
                    {
                        etat = Scenario1Manager.Etat.fini;

                    }
                }
            }

            foreach (GameObject Vanne in Vannes)
            {
                if (Vanne.GetComponent<VanneManager>().ouvert)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    vannecompteur += 1;
                }
                if (etat == Scenario1Manager.Etat.fini && !Vanne.GetComponent<VanneManager>().ouvert)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    vannecompteur -= 1;
                }
                if (vannecompteur == Vannes.Count)
                {
                    etat = Scenario1Manager.Etat.fini;
                }
            }
        }
        

        int onoffcompteur = 0;

        if (OnOffs.Count != 0)
        {
            foreach (GameObject OnOff in OnOffs)
            {
                if (OnOff.GetComponent<bouton_on_off>().active)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    onoffcompteur += 1;
                }
                if (etat == Scenario1Manager.Etat.fini && !OnOff.GetComponent<bouton_on_off>().active)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    onoffcompteur -= 1;
                }
                if (onoffcompteur == OnOffs.Count)
                {
                    etat = Scenario1Manager.Etat.fini;

                }
            }
        }

        int boutoncompteur = 0;

        if (Boutons.Count != 0)
        {
            foreach (GameObject Bouton in Boutons)
            {
                if (Bouton.GetComponent<boutton_vert>().marche)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    boutoncompteur += 1;
                }
                if (etat == Scenario1Manager.Etat.fini && !Bouton.GetComponent<boutton_vert>().marche)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    boutoncompteur -= 1;
                }
                if (boutoncompteur == Boutons.Count)
                {
                    etat = Scenario1Manager.Etat.fini;

                }
            }
        }

        int busecompteur = 0;

        if (Buses.Count != 0)
        {
            foreach (GameObject Buse in Buses)
            {
                if (Buse.GetComponent<flamme>().active)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    busecompteur += 1;
                }
                if (etat == Scenario1Manager.Etat.fini && !Buse.GetComponent<flamme>().active)
                {
                    etat = Scenario1Manager.Etat.enCours;
                    busecompteur -= 1;
                }
                if (busecompteur == Buses.Count)
                {
                    etat = Scenario1Manager.Etat.fini;

                }
            }
        }

        if (Pince.Count != 0)
        {
            if (Pince[0].GetComponent<etp6_checker>().etape6_fini)
            {
                etat = Scenario1Manager.Etat.fini;
            }
        }
        /*int urgencecompteur = 0;

        foreach (GameObject Urgence in Urgences)
        {
            if (Urgence.GetComponent<bouton_urgence>().marche)
            {
                etat = Scenario1Manager.Etat.enCours;
                urgencecompteur += 1;
            }
            if (etat == Scenario1Manager.Etat.fini && !Urgence.GetComponent<bouton_urgence>().marche)
            {
                etat = Scenario1Manager.Etat.enCours;
                urgencecompteur -= 1;
            }
            if (urgencecompteur == Urgences.Count)
            {
                etat = Scenario1Manager.Etat.fini;

            }
        }*/
    }
}
