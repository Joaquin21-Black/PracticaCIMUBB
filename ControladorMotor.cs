using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMotor : MonoBehaviour
{
    void Start()
    {
        var hinge = GetComponent<HingeJoint>();

        // Make the hinge motor rotate with 90 degrees per second and a strong force.
        var motor = hinge.motor;
        motor.force = 0;
        motor.targetVelocity = 0;
        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;
    }
    void Update(){
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;
        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;
        if(Input.GetKey(KeyCode.A)){
            Debug.Log("entre xd");
            motor.targetVelocity = -90;
            motor.force = 100;
        }
        else{
            motor.targetVelocity = -90;
            motor.force = 0;
        }
        if(Input.GetKey(KeyCode.D)){
            motor.targetVelocity = 90;
        }
        else{
            motor.targetVelocity = -90;
            motor.force = 100;
        }
    }
}
 