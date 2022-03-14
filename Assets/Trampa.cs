using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public GameObject ActivarTrampa;
    public Rigidbody Esfera;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Jugador")
        {
            Esfera.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}