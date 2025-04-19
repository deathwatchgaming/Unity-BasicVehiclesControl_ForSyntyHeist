/*
 * File: Police Charger 02 Entry (New Input System)
 * Name: PoliceCharger02Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
 */

// using
using UnityEngine;
using NavigationControl;
using System.Collections;
using UnityEngine.InputSystem;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class PoliceCharger02Entry 
    public class PoliceCharger02Entry : MonoBehaviour
    {
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The police charger game object")]
            // GameObject _policeCharger02
            [SerializeField] private GameObject _policeCharger02;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
            
        // Rigidbody Sleep
        [Header("Rigidbody Sleep")]

            [Tooltip("The rigidBody sleep wait for seconds duration")]
            // float duration is 0.0001
            [SerializeField] private float duration = 0.0001f; 
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inPoliceCharger02 is false
            [SerializeField] private bool _inPoliceCharger02 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The police charger 02 compass")]
            //  PoliceCharger02Compass _charger02Compass
            [SerializeField] private PoliceCharger02Compass _charger02Compass;

        // Input Actions
        [Header("Input Actions")] 

            [Tooltip("The input action asset")]
            // InputActionAsset _carControls
            [SerializeField] private InputActionAsset _carControls;

        // InputAction _carEnterAction
        private InputAction _carEnterAction;

        // InputAction _carExitAction
        private InputAction _carExitAction;

        // bool _enterButton
        private bool _enterButton;

        // bool _exitButton
        private bool _exitButton;

        // PoliceCharger02Controller _policeCharger02Script
        private PoliceCharger02Controller _policeCharger02Script;
        
        // Camera _policeCharger02Camera
        private Camera _policeCharger02Camera;

        // AudioListener _policeCharger02CameraAudioListener
        private AudioListener _policeCharger02CameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;

        // GameObject FindInActiveObjectByName
        GameObject FindInActiveObjectByName(string name)
        {
            // Transform[] objs
            Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];

            // for 
            for (int i = 0; i < objs.Length; i++)
            {
                // if
                if (objs[i].hideFlags == HideFlags.None)
                {
                    // if
                    if (objs[i].name == name)
                    {
                        // return
                        return objs[i].gameObject;

                    } // close if

                } // close if

            } // close for

            // return
            return null;

        } // close GameObject FindInActiveObjectByName

        //public static PoliceCharger02Entry _policeCharger02Entry;         

        // private void Awake
        private void Awake()
        {
            // _carEnterAction
            _carEnterAction = _carControls.FindActionMap("Car").FindAction("Enter");

            // _carExitAction
            _carExitAction = _carControls.FindActionMap("Car").FindAction("Exit");

        } // close private void Awake

        // private void OnEnable
        private void OnEnable()
        {
            // _carEnterAction Enable
            _carEnterAction.Enable();

            // _carExitAction Enable
            _carExitAction.Enable();

        } // close private void OnEnable

        // private void OnDisable
        private void OnDisable()
        {
            // _carEnterAction Disable
            _carEnterAction.Disable();

            // _carExitAction Disable
            _carExitAction.Disable();  

        } // close private void OnDisable

        // private void Start
        private void Start() 
        {
            //_policeCharger02Entry = this;

            // _policeCharger02Script is GetComponent PoliceCharger02Controller
            _policeCharger02Script = GetComponent<PoliceCharger02Controller>();

            // _policeCharger02Script enabled is false
            _policeCharger02Script.enabled = false;
            
            // _policeCharger02Camera is GetComponentInChildren Camera
            _policeCharger02Camera = GetComponentInChildren<Camera>();
            
            // _policeCharger02Camera enabled is false
            _policeCharger02Camera.enabled = false;
           
            // _policeCharger02CameraAudioListener is GetComponentInChildren AudioListener
            _policeCharger02CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCharger02CameraAudioListener enabled is false
            _policeCharger02CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceCharger02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceCharger02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);  

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _charger02Compass enabled is false
            _charger02Compass.enabled = false;

            // _charger02Compass compassEnabled is false
            _charger02Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Charger02 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if_carEnterAction triggered
            if (_carEnterAction.triggered)
            {
                // _enterButton is true
                _enterButton = true;

                // _exitButton is false
                _exitButton = false;

            } // close if_carEnterAction triggered

            // if _carExitAction triggered
            if (_carExitAction.triggered)
            {
                // _enterButton is false
                _enterButton = false;

                // _exitButton is true
                _exitButton = true;

            } // close if _carExitAction triggered
                        
            // if _inPoliceCharger02 and Input GetKey KeyCode _exitKey
            if (_inPoliceCharger02 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCharger02Script enabled is false
                _policeCharger02Script.enabled = false;
                
                // _policeCharger02Camera enabled is false
                _policeCharger02Camera.enabled = false;

                // _policeCharger02CameraAudioListener enabled is false
                _policeCharger02CameraAudioListener.enabled = false;

                // _inPoliceCharger02 is false
                _inPoliceCharger02 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled"); 

                // _charger02Compass enabled is false
                _charger02Compass.enabled = false;

                // _charger02Compass compassEnabled is false
                _charger02Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Charger02 compass is disabled");

            } // close if _inPoliceCharger02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCharger02 and gameObject tag is Player
            if (!_inPoliceCharger02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCharger02 and gameObject tag is Player
            
            // if not _inPoliceCharger02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCharger02 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCharger02 transform
                _player.transform.parent = _policeCharger02.transform;

                // _policeCharger02Script enabled is true
                _policeCharger02Script.enabled = true;
                
                // _policeCharger02Camera enabled is true
                _policeCharger02Camera.enabled = true;

                // _policeCharger02CameraAudioListener enabled is true
                _policeCharger02CameraAudioListener.enabled = true;

                // _inPoliceCharger02 is true
                _inPoliceCharger02 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled");

                // _charger02Compass enabled is true
                _charger02Compass.enabled = true;

                // _charger02Compass compassEnabled is true
                _charger02Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Charger02 compass is enabled");
 
            } // close if not _inPoliceCharger02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
            // if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);
                
                // StartCoroutine RigidbodySleep duration
                StartCoroutine(RigidbodySleep(duration)); 

            } // close if gameObject tag is Player

        } // close private void OnTriggerExit Collider other

        // private IEnumerator RigidbodySleep float duration
        private IEnumerator RigidbodySleep(float duration) 
        {
            // WaitForSeconds duration
            yield return new WaitForSeconds(duration);
            
            // _rigidbody Sleep
            _rigidbody.Sleep();

        } // close private IEnumerator RigidbodySleep float duration  
        
    } // close public class PoliceCharger02Entry  

} // close namespace VehiclesControl
