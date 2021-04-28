using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    int cont = 0;
    public float speed = 4f;
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
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (cont != 2)
            {
                this.transform.position = this.transform.position + new Vector3(speed, 0, 0);
                cont += 1; 
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
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
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Suelo"))
        {
            enElSuelo = true;

        }
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            enElSuelo = true;

        }
    }
}
