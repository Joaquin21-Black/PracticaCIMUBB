using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestSave : MonoBehaviour
{
    public Data data;

    public const string pathData = "Data/";
    public const string namefileData = "Guardado1";


    //carga la data guardada
    private void Start()
    {
        var dataFound = SaveLoadSystemData.LoadData<Data>(pathData, namefileData);
        if (dataFound != null)
        {
            data = dataFound;
           // loadData();
        }
        else
        {
            data = new Data();
            guardarData();
        }
    }



    public void loadData()
    {
        //GameObject.FindGameObjectWithTag("Player").transform.position = data.Prueba;
        //    GameObject.FindGameObjectWithTag("completo").transform.position = data.completo;
        GameObject.FindGameObjectWithTag("Base").transform.position = data.Base;
        GameObject.FindGameObjectWithTag("Base").transform.rotation = data.BaseR;

        GameObject.FindGameObjectWithTag("Hombro").transform.position = data.Hombro;
        GameObject.FindGameObjectWithTag("Hombro").transform.rotation = data.HombroR;

        GameObject.FindGameObjectWithTag("Brazo").transform.position = data.Brazo;
        GameObject.FindGameObjectWithTag("Brazo").transform.rotation = data.BrazoR;

        GameObject.FindGameObjectWithTag("Antebrazo").transform.position = data.Antebrazo;
        GameObject.FindGameObjectWithTag("Antebrazo").transform.rotation = data.AntebrazoR;

        GameObject.FindGameObjectWithTag("Muñeca").transform.position = data.Muñeca;
        GameObject.FindGameObjectWithTag("Muñeca").transform.rotation = data.MuñecaR;

        GameObject.FindGameObjectWithTag("Mano").transform.position = data.Mano;
        GameObject.FindGameObjectWithTag("Mano").transform.rotation = data.ManoR;

        GameObject.FindGameObjectWithTag("Cubo 1").transform.position = data.Cubo_1;
        GameObject.FindGameObjectWithTag("Cubo 1").transform.rotation = data.Cubo_1R;

        GameObject.FindGameObjectWithTag("Cubo 2").transform.position = data.Cubo_2;
        GameObject.FindGameObjectWithTag("Cubo 2").transform.rotation = data.Cubo_2R;
    }

    public void guardarData()
    {
        //data.Prueba = GameObject.FindGameObjectWithTag("Player").transform.position;

        //  data.completo = GameObject.FindGameObjectWithTag("completo").transform.position;
        data.Base = GameObject.FindGameObjectWithTag("Base").transform.position;
        data.Hombro = GameObject.FindGameObjectWithTag("Hombro").transform.position;
        data.Brazo = GameObject.FindGameObjectWithTag("Brazo").transform.position;
        data.Antebrazo = GameObject.FindGameObjectWithTag("Antebrazo").transform.position;
        data.Muñeca = GameObject.FindGameObjectWithTag("Muñeca").transform.position;
        data.Mano = GameObject.FindGameObjectWithTag("Mano").transform.position;
        data.Cubo_1 = GameObject.FindGameObjectWithTag("Cubo 1").transform.position;
        data.Cubo_2 = GameObject.FindGameObjectWithTag("Cubo 2").transform.position;

        data.BaseR = GameObject.FindGameObjectWithTag("Base").transform.rotation;
        data.HombroR = GameObject.FindGameObjectWithTag("Hombro").transform.rotation;
        data.BrazoR = GameObject.FindGameObjectWithTag("Brazo").transform.rotation;
        data.AntebrazoR = GameObject.FindGameObjectWithTag("Antebrazo").transform.rotation;
        data.MuñecaR = GameObject.FindGameObjectWithTag("Muñeca").transform.rotation;
        data.ManoR = GameObject.FindGameObjectWithTag("Mano").transform.rotation;
        data.Cubo_1R = GameObject.FindGameObjectWithTag("Cubo 1").transform.rotation;
        data.Cubo_2R = GameObject.FindGameObjectWithTag("Cubo 2").transform.rotation;
        SaveData();
    }

    private void SaveData()
    {
        SaveLoadSystemData.SaveData(data, pathData, namefileData);
    }

}
