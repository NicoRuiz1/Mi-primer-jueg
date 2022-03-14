using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControlCharacter : MonoBehaviour
{
    public GameObject characterPrincipal;
    public float velocidad = 20f;
    public GameObject bala;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += new Vector3(0,velocidad*Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles -= new Vector3(0, velocidad * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate (bala, transform.position, transform.rotation);
        }
    }
}