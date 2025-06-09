using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObj : MonoBehaviour
{
    public int dmg;
    public HPManager HPManager;
    // Start is called before the first frame update
    void Start()
    {
        HPManager=FindObjectOfType<HPManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            HPManager.UpdateHP(-dmg);
        }
    }
}
