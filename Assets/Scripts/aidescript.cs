using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class aidescript : MonoBehaviour {

    public Material aide;

    //etape 1
    public Material sauvermat_1;
    public Material sauvermat_111;
    public Material sauvermat_1111;
    public GameObject[] aChanger_1;
    public GameObject[] aChanger_111;
    public GameObject[] aChanger_1111;

    //etape 2
    public Material sauvermat_2;
    public GameObject[] aChanger_2;

    //etape 3
    public Material sauvermat_3;
    public GameObject[] aChanger_3;

    //etape 4
    public Material sauvermat_4;
    public GameObject[] aChanger_4;

    //etape 5
    public Material sauvermat_5;
    public GameObject[] aChanger_5;

    //etape 6
    public Material sauvermat_6;
    public GameObject[] aChanger_6;

    //etape 7
    public Material sauvermat_7;
    public GameObject[] aChanger_7;

    //etape 8
    public Material sauvermat_8;
    public GameObject[] aChanger_8;

    //etape 9
    public Material sauvermat_9;
    public Material sauvermat_99;
    public Material sauvermat_999;
    public GameObject[] aChanger_9;
    public GameObject aChanger_99;
    public GameObject aChanger_999;

    //etape 10
    public Material sauvermat_10;
    public GameObject[] aChanger_10;

    //etape 11
    public Material sauvermat_11;
    public GameObject[] aChanger_11;

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        //etape1
        if (GameObject.Find("étape1").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape1").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours)
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_1[0].GetComponent<Renderer>().material = aide;
                aChanger_1[1].GetComponent<Renderer>().material = aide;
                aChanger_1[2].GetComponent<Renderer>().material = aide;
                aChanger_111[0].GetComponent<Renderer>().material = aide;
                aChanger_111[1].GetComponent<Renderer>().material = aide;
                aChanger_111[2].GetComponent<Renderer>().material = aide;
                aChanger_111[3].GetComponent<Renderer>().material = aide;
                aChanger_1111[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_1[0].GetComponent<Renderer>().material = sauvermat_1;
                aChanger_1[1].GetComponent<Renderer>().material = sauvermat_1;
                aChanger_1[2].GetComponent<Renderer>().material = sauvermat_1;
                aChanger_111[0].GetComponent<Renderer>().material = sauvermat_111;
                aChanger_111[1].GetComponent<Renderer>().material = sauvermat_111;
                aChanger_111[2].GetComponent<Renderer>().material = sauvermat_111;
                aChanger_111[3].GetComponent<Renderer>().material = sauvermat_111;
                aChanger_1111[0].GetComponent<Renderer>().material = sauvermat_1111;
            }
        }

        //etape2
        if ((GameObject.Find("étape1").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape2").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape2").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_2[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_2[0].GetComponent<Renderer>().material = sauvermat_2;
            }
        }

        //etape3
        if ((GameObject.Find("étape2").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape3").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape3").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_3[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_3[0].GetComponent<Renderer>().material = sauvermat_3;
            }
        }

        //etape4
        if ((GameObject.Find("étape3").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape4").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape4").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_4[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_4[0].GetComponent<Renderer>().material = sauvermat_4;
            }
        }

        //etape5
        if ((GameObject.Find("étape4").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape5").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape5").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_5[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_5[0].GetComponent<Renderer>().material = sauvermat_5;
            }
        }

        //etape6
        if ((GameObject.Find("étape5").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape6").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape6").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_6[0].GetComponent<Renderer>().material = aide;
                aChanger_6[1].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_6[0].GetComponent<Renderer>().material = sauvermat_6;
                aChanger_6[1].GetComponent<Renderer>().material = sauvermat_6;
            }
        }

        //etape7
        if ((GameObject.Find("étape6").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape7").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape7").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_7[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_7[0].GetComponent<Renderer>().material = sauvermat_7;
            }
        }

        //etape8
        if ((GameObject.Find("étape7").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape8").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape8").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_8[0].GetComponent<Renderer>().material = aide;
                aChanger_8[1].GetComponent<Renderer>().material = aide;
                aChanger_8[2].GetComponent<Renderer>().material = aide;
                aChanger_8[3].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_8[0].GetComponent<Renderer>().material = sauvermat_8;
                aChanger_8[1].GetComponent<Renderer>().material = sauvermat_8;
                aChanger_8[2].GetComponent<Renderer>().material = sauvermat_8;
                aChanger_8[3].GetComponent<Renderer>().material = sauvermat_8;
            }
        }

        //etape9
        if ((GameObject.Find("étape8").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape9").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape9").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_99.GetComponent<Renderer>().material = aide;
                aChanger_999.GetComponent<Renderer>().material = aide;
                aChanger_9[0].GetComponent<Renderer>().material = aide;
                aChanger_9[1].GetComponent<Renderer>().material = aide;
                aChanger_9[2].GetComponent<Renderer>().material = aide;
                aChanger_9[3].GetComponent<Renderer>().material = aide;
                aChanger_9[4].GetComponent<Renderer>().material = aide;
                aChanger_9[5].GetComponent<Renderer>().material = aide;
                aChanger_9[6].GetComponent<Renderer>().material = aide;
                aChanger_9[7].GetComponent<Renderer>().material = aide;
                aChanger_9[8].GetComponent<Renderer>().material = aide;
                aChanger_9[9].GetComponent<Renderer>().material = aide;
                aChanger_9[10].GetComponent<Renderer>().material = aide;
                aChanger_9[11].GetComponent<Renderer>().material = aide;
                aChanger_9[12].GetComponent<Renderer>().material = aide;
                aChanger_9[13].GetComponent<Renderer>().material = aide;
                aChanger_9[14].GetComponent<Renderer>().material = aide;
                aChanger_9[15].GetComponent<Renderer>().material = aide;
                aChanger_9[16].GetComponent<Renderer>().material = aide;
                aChanger_9[17].GetComponent<Renderer>().material = aide;
                aChanger_9[18].GetComponent<Renderer>().material = aide;
                aChanger_9[19].GetComponent<Renderer>().material = aide;
                aChanger_9[20].GetComponent<Renderer>().material = aide;
                aChanger_9[21].GetComponent<Renderer>().material = aide;
                aChanger_9[22].GetComponent<Renderer>().material = aide;
                aChanger_9[23].GetComponent<Renderer>().material = aide;
                aChanger_9[24].GetComponent<Renderer>().material = aide;
                aChanger_9[25].GetComponent<Renderer>().material = aide;
                aChanger_9[26].GetComponent<Renderer>().material = aide;
                aChanger_9[27].GetComponent<Renderer>().material = aide;
                aChanger_9[28].GetComponent<Renderer>().material = aide;
                aChanger_9[29].GetComponent<Renderer>().material = aide;
                aChanger_9[30].GetComponent<Renderer>().material = aide;
                aChanger_9[31].GetComponent<Renderer>().material = aide;
                aChanger_9[32].GetComponent<Renderer>().material = aide;
                aChanger_9[33].GetComponent<Renderer>().material = aide;
                aChanger_9[34].GetComponent<Renderer>().material = aide;
                aChanger_9[35].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_99.GetComponent<Renderer>().material = sauvermat_99;
                aChanger_999.GetComponent<Renderer>().material = sauvermat_999;
                aChanger_9[0].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[1].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[2].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[3].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[4].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[5].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[6].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[7].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[8].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[9].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[10].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[11].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[12].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[13].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[14].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[15].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[16].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[17].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[18].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[19].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[20].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[21].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[22].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[23].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[24].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[25].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[26].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[27].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[28].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[29].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[30].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[31].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[32].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[33].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[34].GetComponent<Renderer>().material = sauvermat_9;
                aChanger_9[35].GetComponent<Renderer>().material = sauvermat_9;
            }
        }

        //etape10
        if ((GameObject.Find("étape9").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape10").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape10").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_10[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_10[0].GetComponent<Renderer>().material = sauvermat_10;
            }
        }

        //etape11
        if ((GameObject.Find("étape10").GetComponent<StepManager>().etat == Scenario1Manager.Etat.fini) && (GameObject.Find("étape11").GetComponent<StepManager>().etat == Scenario1Manager.Etat.pasFait || GameObject.Find("étape11").GetComponent<StepManager>().etat == Scenario1Manager.Etat.enCours))
        {
            if (Controller.GetHairTriggerDown())
            {
                aChanger_11[0].GetComponent<Renderer>().material = aide;
            }
            if (Controller.GetHairTriggerUp())
            {
                aChanger_11[0].GetComponent<Renderer>().material = sauvermat_11;
            }
        }
    }
}
