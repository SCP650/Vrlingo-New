using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class DoorTrigger : MonoBehaviour
{
    public Transform creditsCanvas;

    private void Start()
    {
        creditsCanvas.localScale = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerPrefs.GetInt("IsTeacher") == 0)
        {
            if (other.gameObject.name == "Local VR Player")
            {
                Debug.Log("TRIGGER TRIGGERED");
                Tween.LocalScale(creditsCanvas, new Vector3(0.01f, 0.01f, 0.01f), 0.5f, 0f);
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (PlayerPrefs.GetInt("IsTeacher") == 0)
        {
            if (other.name == "Local VR Player")
            {
                Debug.Log("TRIGGER ALSO TRIGGERED");
                Tween.LocalScale(creditsCanvas, Vector3.zero, 0.2f, 0f);
            }
        }
    }
    
}
