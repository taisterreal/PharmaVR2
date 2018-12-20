﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode()]
public class RopeController : MonoBehaviour
{

    public Transform [] points;
    public LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer.positionCount = points.Length;
    }
    // Update is called once per frame
    void Update ()
    {
        for (int i = 0; i < points.Length; ++i)
        {
            lineRenderer.SetPosition(i, points[i].position);
        }
    }
}
