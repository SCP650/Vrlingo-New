using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(RealtimeTransform))]
[RequireComponent(typeof(XRGrabInteractable))]
public class NetworkedGrabble : MonoBehaviour
{
    XRGrabInteractable grabble;
    RealtimeTransform realtimeTransform;

    private void Awake()
    {
        grabble = GetComponent<XRGrabInteractable>();
        realtimeTransform= GetComponent<RealtimeTransform>();
        grabble.selectEntered.AddListener(OnGrab);
        grabble.selectExited.AddListener(OnRelease);
    }

    private void OnDestroy()
    {
        grabble.selectEntered.RemoveAllListeners();
    }
    void OnGrab(SelectEnterEventArgs arg0)
    {
        Debug.Log("scp650 on grab request ownership");
        realtimeTransform.RequestOwnership();

    }

    void OnRelease(SelectExitEventArgs arg0)
    {

        Debug.Log("scp650 on release clear ownership");
        //realtimeTransform.ClearOwnership();
    }
}
