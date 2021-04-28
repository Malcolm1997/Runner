using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{

    float avanceDelantero = 10f;
    public GameObject piso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        if (Mathf.Round(transform.position.z) == (-3))
        {
            Instantiate(piso, new Vector3(Random.Range(-8.0f,8.0f), 3, 98), Quaternion.identity);
            Destroy(piso);
        }
    }


}
