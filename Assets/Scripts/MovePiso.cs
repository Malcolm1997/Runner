using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePiso : MonoBehaviour
{
    float avanceDelantero = 10f;
    public GameObject piso;
    

    // Update is called once per frame
    void Update()
    {
        
        movimientoPiso();

        generacionDeMundo();
        
        

    }

    void movimientoPiso()
    {
        this.transform.position = this.transform.position + new Vector3(0, 0, -avanceDelantero * Time.deltaTime);
    }

    void generacionDeMundo()
    {
        if (Mathf.Round(transform.position.z) == (-58))
        {
            Instantiate(piso, new Vector3(0, 0, 137), Quaternion.identity);
            Destroy(piso);
        }
    }

    
    
    
}
