using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjEllaboration : MonoBehaviour
{
    //MLKomar says... this should be a scriptable obj but no time to learn...
    // but simple and violent :pensive: 
    public string hint1 = "";
    public string hint2 = "";
    public string hint3 = "";
    private XRGrabInteractable grabber = null;

    public GameObject hintPrefab;
    public GameObject hintUI; 
    public Transform prefabLocation;

    private void Awake()
    {
        grabber = GetComponent<XRGrabInteractable>();
        grabber.selectEntered.AddListener(OnGrab);
        grabber.selectExited.AddListener(OnRelease);
    }

    private void OnDestroy()
    {
        grabber.selectEntered.RemoveListener(OnGrab);
        grabber.selectExited.RemoveListener(OnRelease);
    }
    void OnGrab(SelectEnterEventArgs arg)
    {
        //create the widget
        GameObject hintUI = Instantiate(hintPrefab);
        PickupUI widget = hintUI.GetComponent<PickupUI>();
        widget.SetupUI(hint1, hint2,hint3); 
    }

    void OnRelease(SelectExitEventArgs arg)
    {
        //kill the widget
        Destroy(hintUI);
    }
}
