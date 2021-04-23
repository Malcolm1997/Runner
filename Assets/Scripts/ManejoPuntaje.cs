using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManejoPuntaje : MonoBehaviour
{
    public Text puntaje;
    string textoPunt;

    void FixedUpdate()
    {
        textoPunt = "Tu Puntaje es: " + Time.frameCount/100;
        puntaje.text = textoPunt;
    }
}