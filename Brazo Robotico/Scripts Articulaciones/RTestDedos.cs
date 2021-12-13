using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTestDedos : MonoBehaviour
{
    float Yrot;
    RaycastHit hit;
    GameObject grabOBJ;
    public Transform grabPos;
    void Update()
    {
        var hinge = GetComponent<HingeJoint>(); //Obtener componente HingeJoint del Objeto
        var motor = hinge.motor;
        motor.force = 10000; // Fuerza de la bisagra contra la gravedad u otros objetos

        Yrot -= Input.GetAxis("Mouse Y");
        Yrot = Mathf.Clamp(Yrot, -80, 80);

        transform.localRotation = Quaternion.Euler(Yrot, 0, 0);
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>())
        {
            grabOBJ = hit.transform.gameObject;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            grabOBJ = null;
        }

        /*if (grabOBJ) 
        {
            grabOBJ.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - grabOBJ.transform.position); //funcion para tirar el objeto
        }*/



        if(Input.GetKey(KeyCode.C)){  //Si la tecla A se pulsa, targetVelocity tendra un valor de -90
            motor.targetVelocity = -90;
        }
        else{
            if(Input.GetKey(KeyCode.V)){ //Si la tecla D se pulsa, targetVelocity tendra un valor de 90
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

    private void OnTriggerEnter(Collider other){
        Debug.Log("colision");

    }
}
