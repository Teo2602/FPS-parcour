using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto"+collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
