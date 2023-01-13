using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }
    public InputActionReference ButtonInputs;

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

    void Start()
    {
        ButtonInputs.action.performed += Action_performed;

        //bind event with inputs 

        //joystick oculus 
        //left joystick

        //right joystick

        //joystick vive
        //vive joystick
        //vive joystick
    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        print("heloo");
    }

    private void Update()
    {

    }
}
