using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayFounder : MonoBehaviour
{
    public List<Transform> points;
    public Transform nextPoint;
    public int i = 0;
    private int pointsSize;
    void Start()
    {
        pointsSize = points.Count-1;
        nextPoint = points[i];
    }


    internal void SetNewPoint()
    {
        i++;
        if (!LastPoint())
        {
            Debug.Log(this);
            nextPoint = points[i];
        }
    }

    public bool LastPoint()
    {
        return (i > pointsSize);
    }
}
