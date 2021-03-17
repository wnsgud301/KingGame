using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulettecontroller : MonoBehaviour
{
    float rotSpeed = 0.0f;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 0.0f;
        }
            

        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.987f;
    }
    
        
}


 
       
