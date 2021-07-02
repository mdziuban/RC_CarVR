using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] string inputSteerAxis = "Horizontal";
    [SerializeField] string inputThrottleAxis = "Vertical";

    public float ThrottleInput {get; private set;}
    public float SteerInput {get; private set;}

    void Start()
    {
        
    }

    void Update()
    {
        SteerInput = Input.GetAxis(inputSteerAxis);
        ThrottleInput = Input.GetAxis(inputThrottleAxis);
    }
}
