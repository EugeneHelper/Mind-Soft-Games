using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPilotController : MonoBehaviour, IStrategyMove
{
    public WayFounder wayFounder;
    private TractorModel tractorModel=new TractorModel();
    //private float speed = 15;
    

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Moving()
    {
       Move();
       RotateAI();
    }


    void Move()
    {
        if (!wayFounder.LastPoint())
        {
            transform.position += GetDirection() * tractorModel.Speed * Time.deltaTime;
        }
    }

    private Vector3 GetDirection()
    {
        return (wayFounder.nextPoint.position - transform.position).normalized;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!wayFounder.LastPoint())
        {
            wayFounder.SetNewPoint();
        }

    }

    void RotateAI()
    {
        if (transform.TransformDirection(Vector3.forward)!=GetDirection())//угол между transformDir и направлением к NextPoint не равен 0
        {
            transform.forward += Time.deltaTime * GetDirection();
        }
    }

    private void OnEnable()
    {
        //StartMove();
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }


}
