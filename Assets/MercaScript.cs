using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercaScript : MonoBehaviour
{
    public int precio;
    public MoneyManager MoneyManager;

    private void Start()
    {
        MoneyManager = FindObjectOfType<MoneyManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            if (MoneyManager.UpdateMoney(-precio))
            {
                Destroy(gameObject); 
            }
        }
    }
}
