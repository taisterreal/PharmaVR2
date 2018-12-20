using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changer_canvas_camera : MonoBehaviour
{

    public Canvas canvas_formateur;

    public Dropdown m_Dropdown;

    public Camera camera_formateur1;
    public Camera camera_formateur2;
    public Camera camera_formateur3;
    public Camera camera_formateur4;
    public Camera camera_formateur5;
    public Camera camera_formateur6;
    public Camera camera_formateur7;
    public Camera camera_formateur8;
    public Camera camera_formateur9;

    
    void Awake()
    {
        
    }
    // Use this for initialization
    void Start()
    {
        //canvas_formateur = GetComponent<Canvas>();

        
        canvas_formateur.renderMode = RenderMode.ScreenSpaceCamera;
        

    }

    // Update is called once per frame
    void Update()
    {

         
         if (m_Dropdown.value == 0)
         {
            canvas_formateur.worldCamera = camera_formateur1;
            camera_formateur1.depth = 1;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
            

        }

        if (m_Dropdown.value == 1)
        {
            canvas_formateur.worldCamera = camera_formateur2;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 1;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 2)
        {
            canvas_formateur.worldCamera = camera_formateur3;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 1;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 3)
        {
            canvas_formateur.worldCamera = camera_formateur4;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 1;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 4)
        {
            canvas_formateur.worldCamera = camera_formateur5;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 1;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 5)
        {
            canvas_formateur.worldCamera = camera_formateur6;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 1;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 6)
        {
            canvas_formateur.worldCamera = camera_formateur7;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 1;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 7)
        {
            canvas_formateur.worldCamera = camera_formateur8;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 1;
            camera_formateur9.depth = 0;
        }

        if (m_Dropdown.value == 8)
        {
            canvas_formateur.worldCamera = camera_formateur9;
            camera_formateur1.depth = 0;
            camera_formateur2.depth = 0;
            camera_formateur3.depth = 0;
            camera_formateur4.depth = 0;
            camera_formateur5.depth = 0;
            camera_formateur6.depth = 0;
            camera_formateur7.depth = 0;
            camera_formateur8.depth = 0;
            camera_formateur9.depth = 1;
        }
    }
}
