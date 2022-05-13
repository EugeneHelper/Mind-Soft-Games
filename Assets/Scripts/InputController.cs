using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private float inpMoveValue;
    private float inpTurnTractorValue;
    private float inpTurnCameraValue;
    private bool flagAI;

    public event Action OnAotoPilotSwitchGetKey;
    public event Action OnWASDGetKey;

    public float InpMoveValue { get => inpMoveValue; set => inpMoveValue = value; }
    public float InpTurnTractorValue { get => inpTurnTractorValue; set => inpTurnTractorValue = value; }
    public float InpTurnCameraValue { get => inpTurnCameraValue; set => inpTurnCameraValue = value; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InpTurnTractorValue = Input.GetAxis("Horizontal");
        InpMoveValue = Input.GetAxis("Vertical");
        InpTurnCameraValue = Input.GetAxis("Mouse X");

        if (Input.GetKeyDown(KeyCode.N))
        {

            OnAotoPilotSwitchGetKey?.Invoke();
        }

        if (InpMoveValue != 0|| InpTurnTractorValue!=0)
        {
            OnWASDGetKey?.Invoke();
        }
    }
}
