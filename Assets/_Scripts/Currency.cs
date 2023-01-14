using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public void AddCurrency(int quantity)
    {
        PlayerPrefs.SetInt("tbucks", quantity);
    }
}
