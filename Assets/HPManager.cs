using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    public int HP;
    public UIManager uimanager;
    // Start is called before the first frame update
    void Start()
    {
        uimanager.UpdateHPTxt(HP.ToString());
    }
    public void UpdateHP(int amount)
    {
        if(HP + amount <= 0)
        {
            Debug.Log("Game Over");
            HP = 0;
        }
        else
        {
            HP += amount;
            uimanager.UpdateHPTxt(HP.ToString());
        }
    }
}
