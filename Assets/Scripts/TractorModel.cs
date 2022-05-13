using UnityEngine;

public class TractorModel 
{
    private Camera playerCamera;
    private float speed =20;
    private float turnSpeed = 40;
    private float lookSpeed = 50;
    private float moveValue;
    private float turnTractorValue;
    private float turnCameraValue;

    public float MoveValue { get => moveValue; set => moveValue = value; }
    public float TurnTractorValue { get => turnTractorValue; set => turnTractorValue = value; }
    public float TurnCameraValue { get => turnCameraValue; set => turnCameraValue = value; }
    public float Speed { get => speed; set => speed = value; }
    public float TurnSpeed { get => turnSpeed; }
    public float LookSpeed { get => lookSpeed; }
    public Camera PlayerCamera { get => playerCamera; set => playerCamera = value; }
   
}
