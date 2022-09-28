using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_GetKey_Moviments : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 Mov;
    public float velocidad = 10;
    public float rotacion = 50;
    

    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        // Mov = Vector3.forward;
        // Mov = Vector3.back;
        // Mov = new Vector3(10, 10, 10f);


        if (Input.GetKey(KeyCode.W)) 
        {
            //transform.Translate(transform.forward * 10f * Time.deltaTime);
            transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        }

       if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(transform.forward * -1 * 10f * Time.deltaTime);
            transform.Translate(Vector3.back * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, -90, 0f) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, 90, 0f) * Time.deltaTime);
        }
    }
}
