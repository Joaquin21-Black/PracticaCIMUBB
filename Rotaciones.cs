using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotaciones : MonoBehaviour{

    public void RotarIZQ(){
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;
        motor.force = 10000;
        motor.targetVelocity = -90;
        hinge.motor = motor;
        hinge.useMotor = true; 
    }

    public void RotarDER(){
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;
        motor.force = 10000;
        motor.targetVelocity = 90;
        hinge.motor = motor;
        hinge.useMotor = true; 
    }

    public void StopRotar(){
        var hinge = GetComponent<HingeJoint>();
        var motor = hinge.motor;
        motor.force = 10000;
        motor.targetVelocity = 0;
        hinge.motor = motor;
        hinge.useMotor = true; 
    }
}
