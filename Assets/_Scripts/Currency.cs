using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Currency : MonoBehaviour
{
    public TextMeshProUGUI currencyText;

    public void AddCurrency(int quantity)
    {
        PlayerPrefs.SetInt("tbucks", quantity);
    }

    private void Update()
    {
        if (currencyText != null)
        {
            currencyText.text = PlayerPrefs.GetInt("tbucks").ToString();
        }
    }
}
