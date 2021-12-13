using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBase : MonoBehaviour
{
    void Update()
    {
        var hinge = GetComponent<HingeJoint>(); //Obtener componente HingeJoint del Objeto
        var motor = hinge.motor;
        motor.force = 10000; // Fuerza de la bisagra contra la gravedad u otros objetos

        if(Input.GetKey(KeyCode.Q)){  //Si la tecla A se pulsa, targetVelocity tendra un valor de -90
            motor.targetVelocity = -90;
        }
        else{
            if(Input.GetKey(KeyCode.W)){ //Si la tecla D se pulsa, targetVelocity tendra un valor de 90
                motor.targetVelocity = 90;
            }
            else{ //Si nada esta presionado se mantiene estatico (targetVelocity = 0)
                motor.targetVelocity = 0;
            }
        }
        motor.freeSpin = false; // Si es true, motor.force acelera velocidad de la bisagra, pero no la frenará
        hinge.motor = motor; // Esta linea es importante o si no no funciona xd
        hinge.useMotor = true; 
    }
}
