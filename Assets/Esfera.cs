using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Carro")
        {
            Debug.Log("Game Over");
            Destroy(collision.gameObject);

        }
    }
}
