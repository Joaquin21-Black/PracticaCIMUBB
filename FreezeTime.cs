using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeTime : MonoBehaviour
{
    public void FreezeButton(){
        if (Time.timeScale == 0){
            Time.timeScale = 1;
        }
        else{
            Time.timeScale = 0;
        } 
    }
}
