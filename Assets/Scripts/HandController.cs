using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController: MonoBehaviour, IStrategyMove
{
    [SerializeField] private InputController inputController;
    TractorModel tractorModel;
    private void Start()
    {
        tractorModel = new TractorModel();
        tractorModel.PlayerCamera = Camera.main;
        Moving();
    }

    void Update()
    {
        tractorModel.TurnTractorValue = inputController.InpTurnTractorValue;
        tractorModel.MoveValue = inputController.InpMoveValue;
        tractorModel.TurnCameraValue = inputController.InpTurnCameraValue;

    }

    public void Moving()
    {
        TurnCamera();

        if (tractorModel.MoveValue != 0)
        {
            Move();
            Rot();
        }
    }

    //private IEnumerator MoveCoroutine()
    //{
    //    while (true)
    //    {
    //        TurnCamera();

    //        if (tractorModel.MoveValue != 0)
    //        {
    //            Move();
    //            Rot();
    //        }

    //        yield return null;
    //    }
    //}

    private void TurnCamera()
    {
        tractorModel.TurnCameraValue *= tractorModel.LookSpeed * Time.deltaTime;
        tractorModel.PlayerCamera.transform.rotation *= Quaternion.Euler(0, tractorModel.TurnCameraValue , 0);
    }

    private void Rot()
    {
        tractorModel.TurnTractorValue *= tractorModel.TurnSpeed *Time.deltaTime;
        transform.Rotate(Vector3.up * tractorModel.TurnTractorValue);
    }

    public void Move()
    {
         Vector3 move = transform.TransformDirection(Vector3.forward * tractorModel.MoveValue);          
         transform.position += move * Time.deltaTime * tractorModel.Speed;
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }


}
