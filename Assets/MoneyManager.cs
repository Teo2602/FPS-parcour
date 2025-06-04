using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uimanager;
    public void Start()
    {
        uimanager.UpdateMoneyText(money.ToString());
    }
    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("no te alcanza");
            return false;
        }
        else
        {
            money += amount;
            uimanager.UpdateMoneyText(money.ToString());
            return true;
        }
        
    }
}
