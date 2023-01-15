using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupUI : MonoBehaviour
{
    public TextMeshProUGUI hint1 = null;
    public TextMeshProUGUI hint2 = null;
    public TextMeshProUGUI hint3 = null;


    public void SetupUI(string h1,string h2,string h3)
    {
        hint1.text = h1;
        hint2.text = h2;
        hint3.text = h3;
    }

    public void Update()
    {
        transform.LookAt(Camera.main.transform.position);
        //transform.rotation.ToEuler().
        
    }
}
