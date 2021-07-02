using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    [SerializeField] float _motorTorque = 1500f;
    [SerializeField] float _maxSteer = 20f;

    private Wheel[] _wheels;
    private Rigidbody _rigidbody;

    public float Steer {get; set;}
    public float Throttle {get; set;}

    private void Start() 
    {
        _wheels = GetComponentsInChildren<Wheel>();
        _rigidbody = GetComponent<Rigidbody>();    
    }

    private void Update() 
    {
        Steer = GameManager.Instance.InputController.SteerInput;
        Throttle = GameManager.Instance.InputController.ThrottleInput;

        foreach (var wheel in _wheels)
        {
            wheel.steerAngle = Steer * _maxSteer;
            wheel.torque = Throttle * _motorTorque;
        }    
    }
}
