using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ManejoPuntaje : MonoBehaviour
{
    public Text puntaje;
    string textoPunt;
    int punt;
    
    void FixedUpdate()
    {
        punt = Time.frameCount / 100;
        textoPunt = "Tu Puntaje es: " + punt;
        puntaje.text = textoPunt;      
    }


}