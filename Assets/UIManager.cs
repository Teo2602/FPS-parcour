using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI PlataVisible;
    // Start is called before the first frame update
    void Start()
    {
        PlataVisible.text = "$0";
    }

    public void UpdateMoneyText(string moneyAmount)
    {
        PlataVisible.text = "$" + moneyAmount;
    }
}
