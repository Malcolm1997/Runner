using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{

    float avanceDelantero = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoPiso();
    }

    void movimientoPiso()
    {
        this.transform.position = this.transform.position + new Vector3(0, 0, -avanceDelantero * Time.deltaTime);
    }
}
