using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiso : MonoBehaviour
{
    float avanceDelantero = 15f;
    public GameObject piso;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(0, 0, avanceDelantero * Time.deltaTime);
    }
}
