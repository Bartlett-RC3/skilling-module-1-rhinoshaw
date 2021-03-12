using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session_3_20_Sashank : MonoBehaviour
{
    float speed = 10f;
   
    

    void Start()
    {
    

    }
   

    // Update is called once per frame
    void Update()
    {
        //Transform 
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -1, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 1, 0);


        //Change color of cube
        if (Input.GetMouseButton(0))
        {
            this.GetComponent<Renderer>().material.color = Color.blue;
        }
        

    }

}
