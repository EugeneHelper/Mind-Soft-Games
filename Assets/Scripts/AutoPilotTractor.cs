using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPilotTractor : TractorModel,IStrategyMove
{
    public WayFounder wayFounder;
    //private float speed = 15;


    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartMove()
    {
        StartCoroutine(nameof(Move));
        StartCoroutine(nameof(RotateAI));
    }


    public IEnumerator Move()
    {

        while (!wayFounder.LastPoint())
        {
            transform.position += GetDirection() * Speed * Time.deltaTime;
            yield return null;
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

    IEnumerator RotateAI()
    {
        while (transform.TransformDirection(Vector3.forward)!=GetDirection())//угол между transformDir и направлением к NextPoint не равен 0
        {
            transform.forward += Time.deltaTime * GetDirection();
            yield return null;
        }
        Debug.Log("Directions are eqaual");

    }

    private void OnEnable()
    {
        StartMove();
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }


}
