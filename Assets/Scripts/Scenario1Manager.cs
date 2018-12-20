using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scenario1Manager : MonoBehaviour
{
    public List<Button> steps;// = new List<string> { "Ouverture vannes de l'armoire", "Démarrage au pupitre", "Démarrage pneumatiques et chaines", "Démarrage séparation", "Démarrage bras manipulateur et chaine", "Vérification des pinces", "Ouverture vannes d'air des noyaux", "Ouverture vannes Oxygène et gaz de formage et séparation", "Allumage des chalumeaux", "Démarrage charge", "Ouverture vanne d'huile des noyaux" };
    public List<GameObject> managers;
    List<Button> stepRestantes;
    Color defaut;
    //string[] checklist = new string[] {";
    //List<string> enCours;
    public enum Etat { fini, enCours, pasFait };


    void Start ()
    {
        defaut = steps[0].GetComponent<Image>().color;
    }
	

	void Update ()
    {
        checkStep();
	}


    public void checkStep()
    {
        foreach(Button step in steps)
        {
            step.image.color = defaut;

            if (step.GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini)
            {
                step.image.color = Color.green;
            }

            else
            {      
                if (step.GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours)
                {
                    step.image.color = Color.yellow;
                }

                checkStepRestantes(steps);
            }
        }
    }

    public void checkStepRestantes(List<Button> steps)
    {
        for(int i = 1; i<steps.Count; i++)
        {
            if (steps[i-1].GetComponent<StepManager>().etat != Scenario1Manager.Etat.fini && (steps[i].GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini || steps[i].GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
            {
                steps[i].image.color = Color.red;
            }
        }
    }


    public bool verifStep(int a, string stepPrecedente, List<string> fini)
    {
        //string stepCourante = checklist[a-1];
        if (stepPrecedente == fini[a - 2])
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
