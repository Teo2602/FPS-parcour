using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI PlataVisible;
    public TextMeshProUGUI HP_Txt;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void UpdateMoneyText(string moneyAmount)
    {
        PlataVisible.text = "$" + moneyAmount;
    }
    public void UpdateHPTxt(string HPAmount)
    {
        HP_Txt.text = "HP " + HPAmount;
    }
}
