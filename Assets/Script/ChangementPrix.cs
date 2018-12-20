using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangementPrix : MonoBehaviour {

    //Variable pour la gestion des prix
    private float Kwh, Eau, Gaz;
    public GameObject VAKwh, VAEau, VAGaz;
    //private string path = "chiffre.txt";
    private string[] entries;
    public InputField PrixKwh, PrixEau, PrixGaz;


    private void Start()
    {
        //On appelle cette methode des le début pour evité de reinitialisé les chiffres
        LireDonnee();

        //on appelle la fonction si on est dans la bonne scène
        if(SceneManager.GetActiveScene().name == "Intro")
            Vactuel();
    }
    //Permet de lire les données dans le document "chiffre.txt"
    public void LireDonnee()
    {
        try
        {
            string line;
            // On crée un reader pour pouvoir parcouriri le texte
            StreamReader theReader = new StreamReader("chiffre.txt");
            using (theReader)
            {
                do
                {
                    line = theReader.ReadLine();

                    if (line != null)
                    {
                        // On sépare les lignes avec les virgules
                        entries = line.Split(',');
                    }
                }
                while (line != null);
                //On assigne les valeur actuel au variables Kwh,Eau et Gaz pour eviter une remise a zéro a chaque lancement
                SetKwh(float.Parse(entries[0]));
                SetEau(float.Parse(entries[1]));
                SetGaz(float.Parse(entries[2]));
                // On ferme le reader quand on a finit d'utiliser le document
                theReader.Close();
            }
        }
        // En cas de bug
        catch (Exception e)
        {
            Console.WriteLine("{0}\n", e.Message);
        }
    }
    //Permet de changer les valeur dans le documents "chiffre.txt"
    public void Changement()
    {
        // Create a string array with the lines of text
        string text = GetKwh() + "," + GetEau() + "," + GetGaz();

        // Write the text to a new file named "WriteFile.txt".
        File.WriteAllText("chiffre.txt", text);

        //On appelle la fonction pour actualiser les données afficher
        Vactuel();
    }
    //Creation de get/set pour chaque variable de prix -> pour eviter les 
    //erreurs ou des valeur impossible pour les variable Kwh/eau/Gaz
    public void SetKwh(float chang)
    {
        if(chang >= 0)
            Kwh = chang;
    }

    public void SetEau(float chang)
    {
        if (chang >= 0)
            Eau = chang;
    }

    public void SetGaz(float chang)
    {
        if (chang >= 0)
            Gaz = chang;
    }

    public float GetKwh()
    {
        return Kwh;
    }

    public float GetEau()
    {
        return Eau;
    }

    public float GetGaz()
    {
        return Gaz;
    }
    //Script pour modifier les valeur de chaque variable
    public void KwhChangement()
    {
        string RecupText = PrixKwh.text;
        float a = float.Parse(RecupText);
        SetKwh(a);
    }
    public void EauChangement()
    {
        string RecupText = PrixEau.text;
        float a = float.Parse(RecupText);
        SetEau(a/1000);
    }
    public void GazChangement()
    {
        string RecupText = PrixGaz.text;
        float a = float.Parse(RecupText);
        SetGaz(a);
    }

    //Methode pour afficher la valeur actuel des prix
    public void Vactuel()
    {
        VAKwh.GetComponent<Text>().text = "Kwh : " + GetKwh().ToString() + " €";
        VAEau.GetComponent<Text>().text = "Eau : " + GetEau().ToString() + " €";
        VAGaz.GetComponent<Text>().text = "Gaz : " + GetGaz().ToString() + " €";
    }
}