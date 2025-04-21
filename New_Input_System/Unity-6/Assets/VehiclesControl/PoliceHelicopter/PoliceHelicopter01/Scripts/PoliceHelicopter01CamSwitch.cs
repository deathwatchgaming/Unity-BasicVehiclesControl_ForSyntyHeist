/*
 * Name: Police Helicopter 01 Camera Switcher (New Input System)
 * File: PoliceHelicopter01CamSwitch.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+ 
*/

// using
using UnityEngine;
using UnityEngine.InputSystem;

// namespace VehiclesControl
namespace VehiclesControl
{
    // public class PoliceHelicopter01CamSwitch
    public class PoliceHelicopter01CamSwitch : MonoBehaviour 
    {
        [Tooltip("The cameras ie: 0: Rear Camera & 1: Cockpit Camera")]
        // private Camera[] _cameras
        [SerializeField] private Camera[] _cameras;

        // Input
        [Header("Input Actions")]

            [Tooltip("The input action asset")]
            // InputActionAsset _helicopterControls
            [SerializeField] private InputActionAsset _helicopterControls;

        // private int currentCameraIndex
        private int currentCameraIndex;

        // InputAction _helicopterCameraAction
        private InputAction _helicopterCameraAction;

        // bool _cameraSwitchValue
        private bool _cameraSwitchValue;

        // private void Awake
        private void Awake() 
        {
            // _helicopterCameraAction
            _helicopterCameraAction = _helicopterControls.FindActionMap("Helicopter").FindAction("CameraSwitch");

        } // close private void Awake

        // private void OnEnable
        private void OnEnable()
        {
            // _helicopterCameraAction Enable
            _helicopterCameraAction.Enable();

        } // close private void OnEnable

        // private void OnDisable
        private void OnDisable()
        {
            // _helicopterCameraAction Disable
            _helicopterCameraAction.Disable();

        } // close private void OnDisable

        // Use Start for initialization
        
        // private void Start
        private void Start() 
        {
            // currentCameraIndex is 0
            currentCameraIndex = 0;

            // Turn all cameras off except the first default one

            // for
            for (int i = 1; i < _cameras.Length; i++) 
            {
                // _cameras[i] gameObject SetActive is false
                _cameras[i].gameObject.SetActive(false);

            } // close for

            // If any cameras were added to the Camera Switcher, enable the first camera

            // if
            if (_cameras.Length > 0)
            {
                // _cameras[0] gameObject SetActive is true
                _cameras[0].gameObject.SetActive(true);

                // Debug Log
                //Debug.Log ("Camera with name: " + _cameras[0].GetComponent<Camera>().name + ", is now enabled");

            } // close if

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update() 
        {
            // _cameraSwitchValue
            _cameraSwitchValue = _helicopterCameraAction.WasPressedThisFrame();
                        
            // If the change camera button is pressed switch to the next camera
            // Set the camera at the current index to inactive and set the next one in the array to active
            // When we reach the end of the camera array move back to the beginning of the array

            // if Input Get Key Down _cameraSwitchKey
            if (_cameraSwitchValue)
            {
                // Change Camera
                ChangeCamera();

            } // close if Input Get Key Down _cameraSwitchKey

        } // close void Update

        // private void ChangeCamera
        private void ChangeCamera()
        {
            // currentCameraIndex plus
            currentCameraIndex++;

            // Debug Log
            //Debug.Log ("The change camera button has been pressed. Switching to the next camera");

            // if
            if (currentCameraIndex < _cameras.Length)
            {
                // _cameras[currentCameraIndex - 1] gameObject SetActive is false
                _cameras[currentCameraIndex - 1].gameObject.SetActive(false);

                // _cameras[currentCameraIndex] gameObject SetActive is true
                _cameras[currentCameraIndex].gameObject.SetActive(true);

                // Debug Log
                //Debug.Log ("Camera with name: " + _cameras[currentCameraIndex].GetComponent<Camera>().name + ", is now enabled");

            } // close if

            // else
            else
            {
                // _cameras[currentCameraIndex - 1] gameObject SetActive is false
                _cameras[currentCameraIndex - 1].gameObject.SetActive(false);

                // currentCameraIndex is 0
                currentCameraIndex = 0;

                // _cameras[currentCameraIndex] gameObject SetActive is true
                _cameras[currentCameraIndex].gameObject.SetActive(true);

                // Debug Log
                //Debug.Log ("Camera with name: " + _cameras[currentCameraIndex].GetComponent<Camera>().name + ", is now enabled");

            } // close else

        } // close private void ChangeCamera

    } // close public class PoliceHelicopter01CamSwitch

} // close namespace VehiclesControl
