using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    private InputDevice LeftController; 
    private InputDevice RightController;

    private void Awake()
    {
        //set up input manager singelton
        if (Instance == null)
        {
            Instance = this;
        }
        else Destroy(Instance);      
    }
    // Start is called before the first frame update
    IEnumerator FindControllers()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);
        print("finding controllers");
        if (devices.Count > 2)
        {
            print("found controllers");
            LeftController = devices[1];
            RightController = devices[2];
            StartCoroutine(ControllerInput());
            yield return null;
        }
        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator ControllerInput()
    {
        while (true)
        {
            print("check controls");
            LeftController.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonVal);
            if (primaryButtonVal){
                print("primary button pressed");
            }
            LeftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool secondaryButtonVal);
            if (primaryButtonVal)
            {
                print("secondary button pressed");
            }
            if (LeftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisVal))
            {
                print("Left Joystick val" + primary2DAxisVal);
            }
        }
        print("done");
        yield return null;

    }
    void Start()
    {
        StartCoroutine(FindControllers());
        //bind event with inputs 

        //joystick oculus 
        //left joystick

        //right joystick

        //joystick vive
        //vive joystick
        //vive joystick
    }

    private void Update()
    {
        

    }
}
