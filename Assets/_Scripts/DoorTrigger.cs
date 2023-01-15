using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class DoorTrigger : MonoBehaviour
{
    public Transform creditsCanvas;
    public Transform exitCanvas;

    private void Start()
    {
        creditsCanvas.localScale = Vector3.zero;
        exitCanvas.localScale = Vector3.one;
        creditsCanvas.gameObject.SetActive(false);
        exitCanvas.gameObject.SetActive(false);
    }

    public void ShowExitPanel()
    {
        exitCanvas.gameObject.SetActive(true);
        Tween.LocalScale(exitCanvas, new Vector3(0.01f, 0.01f, 0.01f), 0.5f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"on trigger enter {other.name}");
        if (other.gameObject.name == "HeadModel")
        {
            if (PlayerPrefs.GetInt("IsTeacher") == 1)
            {
                creditsCanvas.gameObject.SetActive(true);
                Debug.Log("TRIGGER TRIGGERED");
                Tween.LocalScale(creditsCanvas, new Vector3(0.01f, 0.01f, 0.01f), 0.5f, 0f);
            }
            else
            {
                exitCanvas.gameObject.SetActive(true);
                Debug.Log("student TRIGGER TRIGGERED");
                Tween.LocalScale(exitCanvas, new Vector3(0.01f, 0.01f, 0.01f), 0.5f, 0f);
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "HeadModel")
        {
                Debug.Log("on trigger exit student");
                Tween.LocalScale(creditsCanvas, Vector3.zero, 0.2f, 0f);
                Tween.LocalScale(exitCanvas, Vector3.zero, 0.2f, 0f);
        }
    }
    
}
