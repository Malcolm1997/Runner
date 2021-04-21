﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    int cont = 0;
    public float speed = 5f;
    public float avanceDelantero = 1f;
    public float salto = 5f;
    public Rigidbody rb;
    bool enElSuelo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        movimiento();
    }

    void movimiento()
    {
        if (Input.GetKeyDown("a"))
        {
            if (cont != 2)
            {
                this.transform.position = this.transform.position + new Vector3(speed, 0, 0);
                cont += 1; 
            }
        }
        if (Input.GetKeyDown("d"))
        {
            if (cont != -2)
            {
                this.transform.position = this.transform.position - new Vector3(speed, 0, 0);
                cont -= 1;
            }
        }
        if (Input.GetKeyDown("space") && enElSuelo == true)
        {
            rb.AddForce(0, salto, 0, ForceMode.Impulse);
            enElSuelo = false;
        }
        
        this.transform.position = this.transform.position + new Vector3(0, 0, avanceDelantero * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Suelo"))
        {
            enElSuelo = true;
        }
    }
}