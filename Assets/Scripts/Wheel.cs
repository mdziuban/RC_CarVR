using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] bool steer;
    [SerializeField] bool power;
    public float steerAngle {get; set;}
    public float torque {get; set;}

    private Wheel[] wheels;

    WheelCollider wheelCollider;
    Transform wheelTransform;

    void Start()
    {
        
        wheelCollider = GetComponentInChildren<WheelCollider>();
        wheelTransform = GetComponentInChildren<MeshRenderer>().GetComponent<Transform>();
    }

    void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }

    private void FixedUpdate() 
    {
        if (steer)
        {
            wheelCollider.steerAngle = steerAngle;
        }     

        if (power)
        {
            wheelCollider.motorTorque = torque;
        }
    }
}
