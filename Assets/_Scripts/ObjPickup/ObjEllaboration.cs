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
    private GameObject hintUI; 
    public Transform prefabLocation;

    private void Awake()
    {
        grabber = transform.parent.GetComponent<XRGrabInteractable>();
        grabber.selectEntered.AddListener(OnGrab);
        grabber.selectExited.AddListener(OnRelease);
    }

    private void OnDestroy()
    {
        grabber.selectEntered.RemoveListener(OnGrab);
        grabber.selectExited.RemoveListener(OnRelease);
    }

    void CreateWidget()
    {
        //create the widget
        hintUI = Instantiate(hintPrefab, prefabLocation.position, prefabLocation.rotation);

        hintUI.transform.parent = prefabLocation;
        PickupUI widget = hintUI.GetComponent<PickupUI>();
        widget.SetupUI(hint1, hint2, hint3);

        //cringe
        var scale = prefabLocation.localScale;
        scale.x *= -1.0f;
        prefabLocation.localScale = scale;
    }
    private void Start()
    {
        //CreateWidget();
    }

    void OnGrab(SelectEnterEventArgs arg)
    {
        CreateWidget();
    }

    void OnRelease(SelectExitEventArgs arg)
    {
        //kill the widget
        Destroy(hintUI);
    }
}
