/*
 * File: Police Helicopter 03 Entry (New Input System)
 * Name: PoliceHelicopter03Entry.cs
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

    // public class PoliceHelicopter03Entry 
    public class PoliceHelicopter03Entry : MonoBehaviour
    {
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The policeHelicopter03 game object")]
            // GameObject _policeHelicopter03
            [SerializeField] private GameObject _policeHelicopter03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;

            [Tooltip("The interface HUD game object")]
            // GameObject _interfaceHUDObject
            [SerializeField] private GameObject _interfaceHUDObject;            
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inPoliceHelicopter03 is false
            [SerializeField] private bool _inPoliceHelicopter03 = false;

        // Cameras
        [Header("Cameras")]

            [Tooltip("The cameras ie: 0: Rear Camera & 1: Cockpit Camera")]
            // private Camera[] _cameras
            [SerializeField] private Camera[] _cameras;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The police helicopter 03 compass")]
            // PoliceHelicopter03Compass _heli03Compass
            [SerializeField] private PoliceHelicopter03Compass _heli03Compass;

        // Input Actions
        [Header("Input Actions")] 

            [Tooltip("The input action asset")]
            // InputActionAsset _helicopterControls
            [SerializeField] private InputActionAsset _helicopterControls;

        // InputAction _helicopterEnterAction
        private InputAction _helicopterEnterAction;

        // InputAction _helicopterExitAction
        private InputAction _helicopterExitAction;

        // bool _enterButton
        private bool _enterButton;

        // bool _exitButton
        private bool _exitButton;
        
        // PoliceHelicopter03Controller _policeHelicopter03Script
        private PoliceHelicopter03Controller _policeHelicopter03Script;

        // PoliceHelicopter03CamSwitch _policeHelicopter03CamScript
        private PoliceHelicopter03CamSwitch _policeHelicopter03CamScript;
        
        // Camera _policeHelicopter03Camera01
        private Camera _policeHelicopter03Camera01;

        // AudioListener _policeHelicopter03Camera01AudioListener
        private AudioListener _policeHelicopter03Camera01AudioListener;

        // Camera _policeHelicopter03Camera02
        private Camera _policeHelicopter03Camera02;

        // AudioListener _policeHelicopter03Camera02AudioListener
        private AudioListener _policeHelicopter03Camera02AudioListener;

        // Camera _policeHelicopter03Camera03
        private Camera _policeHelicopter03Camera03;

        // AudioListener _policeHelicopter03Camera03AudioListener
        private AudioListener _policeHelicopter03Camera03AudioListener;

        // AudioSource _policeHelicopter03AudioSource
        private AudioSource _policeHelicopter03AudioSource;

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

        //public static PoliceHelicopter03Entry _policeHelicopter03Entry;

        // private void Awake
        private void Awake()
        {
            // _helicopterEnterAction
            _helicopterEnterAction = _helicopterControls.FindActionMap("Helicopter").FindAction("Enter");

            // _helicopterExitAction
            _helicopterExitAction = _helicopterControls.FindActionMap("Helicopter").FindAction("Exit");

        } // closeprivate void Awake

        // private void OnEnable
        private void OnEnable()
        {
            // _helicopterEnterAction Enable
            _helicopterEnterAction.Enable();

            // _helicopterExitAction Enable
            _helicopterExitAction.Enable();

        } // closeprivate void OnEnable

        // private void OnDisable
        private void OnDisable()
        {
            // _helicopterEnterAction Disable
            _helicopterEnterAction.Disable();

            // _helicopterExitAction Disable
            _helicopterExitAction.Disable();

        } // closeprivate void OnDisable

        // private void Start
        private void Start() 
        {
            //_policeHelicopter03Entry = this;

            // _policeHelicopter03Script is GetComponent PoliceHelicopter03Controller
            _policeHelicopter03Script = GetComponent<PoliceHelicopter03Controller>();

            // _policeHelicopter03Script enabled is false
            _policeHelicopter03Script.enabled = false;

            // _policeHelicopter03CamScript is GetComponent PoliceHelicopter03CamSwitch
            _policeHelicopter03CamScript = GetComponent<PoliceHelicopter03CamSwitch>();

            // _policeHelicopter03CamScript enabled is false
            _policeHelicopter03CamScript.enabled = false;

            // _policeHelicopter03Camera01 is GetComponentInChildren Camera
            _policeHelicopter03Camera01 = _cameras[0].GetComponentInChildren<Camera>();

            // _policeHelicopter03Camera01 enabled is false
            _policeHelicopter03Camera01.enabled = false;

            // _policeHelicopter03Camera01AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter03Camera01AudioListener = _cameras[0].GetComponentInChildren<AudioListener>();

            // _policeHelicopter03Camera01AudioListener enabled is false
            _policeHelicopter03Camera01AudioListener.enabled = false;

            // _policeHelicopter03Camera02 is GetComponentInChildren Camera
            _policeHelicopter03Camera02 = _cameras[1].GetComponentInChildren<Camera>();

            // _policeHelicopter03Camera02 enabled is false
            _policeHelicopter03Camera02.enabled = false;

            // _policeHelicopter03Camera02AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter03Camera02AudioListener = _cameras[1].GetComponentInChildren<AudioListener>();

            // _policeHelicopter03Camera02AudioListener enabled is false
            _policeHelicopter03Camera02AudioListener.enabled = false;

            // _policeHelicopter03Camera03 is GetComponentInChildren Camera
            _policeHelicopter03Camera03 = _cameras[2].GetComponentInChildren<Camera>();

            // _policeHelicopter03Camera03 enabled is false
            _policeHelicopter03Camera03.enabled = false;

            // _policeHelicopter03Camera03AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter03Camera03AudioListener = _cameras[2].GetComponentInChildren<AudioListener>();

            // _policeHelicopter03Camera03AudioListener enabled is false
            _policeHelicopter03Camera03AudioListener.enabled = false;

            // _policeHelicopter03AudioSource
            _policeHelicopter03AudioSource = GetComponent<AudioSource>();

            // _policeHelicopter03AudioSource enabled is false
            _policeHelicopter03AudioSource.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject 
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceHelicopter03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false); 

            // GameObject _interfaceHUDObject 
            GameObject _interfaceHUDObject = FindInActiveObjectByName("PoliceHelicopter03_HUD");
            
            // _interfaceHUDObject SetActive is false
            _interfaceHUDObject.SetActive(false); 

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _heli03Compass enabled is false
            _heli03Compass.enabled = false;

            // _heli03Compass compassEnabled is false
            _heli03Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Heli03 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if_helicopterEnterAction triggered
            if (_helicopterEnterAction.triggered)
            {
                // _enterButton is true
                _enterButton = true;

                // _exitButton is false
                _exitButton = false;

            } // close if_helicopterEnterAction triggered

            // if _helicopterExitAction triggered
            if (_helicopterExitAction.triggered)
            {
                // _enterButton is false
                _enterButton = false;

                // _exitButton is true
                _exitButton = true;

            } // close if _helicopterExitAction triggered
                        
            // if _inPoliceHelicopter03 and Input GetKey KeyCode _exitKey
            if (_inPoliceHelicopter03 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeHelicopter03Script enabled is false
                _policeHelicopter03Script.enabled = false;

                // _policeHelicopter03CamScript enabled is false
                _policeHelicopter03CamScript.enabled = false;                
                
                // _policeHelicopter03Camera01 enabled is false
                _policeHelicopter03Camera01.enabled = false;

                // _policeHelicopter03Camera01AudioListener enabled is false
                _policeHelicopter03Camera01AudioListener.enabled = false;

                // _policeHelicopter03Camera02 enabled is false
                _policeHelicopter03Camera02.enabled = false;

                // _policeHelicopter03Camera02AudioListener enabled is false
                _policeHelicopter03Camera02AudioListener.enabled = false;

                // _policeHelicopter03Camera03 enabled is false
                _policeHelicopter03Camera03.enabled = false;

                // _policeHelicopter03Camera03AudioListener enabled is false
                _policeHelicopter03Camera03AudioListener.enabled = false;

                // _policeHelicopter03AudioSource enabled is false
                _policeHelicopter03AudioSource.enabled = false;          

                // _inPoliceHelicopter03 is false
                _inPoliceHelicopter03 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _heli03Compass enabled is false
                _heli03Compass.enabled = false;

                // _heli03Compass compassEnabled is false
                _heli03Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Heli03 compass is disabled");

            } // close if _inPoliceHelicopter03 and Input GetKey KeyCode _exitKey

        } // close private void Update     

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceHelicopter03 and gameObject tag is Player
            if (!_inPoliceHelicopter03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

                // _interfaceHUDObject SetActive is false
                _interfaceHUDObject.SetActive(false); 

            } // close if not _inPoliceHelicopter03 and gameObject tag is Player
            
            // if not _inPoliceHelicopter03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceHelicopter03 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _interfaceHUDObject SetActive is true
                _interfaceHUDObject.SetActive(true);                

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeHelicopter03 transform
                _player.transform.parent = _policeHelicopter03.transform;

                // _policeHelicopter03Script enabled is true
                _policeHelicopter03Script.enabled = true;

                // _policeHelicopter03CamScript enabled is true
                _policeHelicopter03CamScript.enabled = true;                

                // _policeHelicopter03Camera01 enabled is true                    
                _policeHelicopter03Camera01.enabled = true;

                // _policeHelicopter03Camera01AudioListener enabled is true
                _policeHelicopter03Camera01AudioListener.enabled = true;

                // _policeHelicopter03Camera02 enabled is true
                _policeHelicopter03Camera02.enabled = true;

                // _policeHelicopter03Camera02AudioListener enabled is true
                _policeHelicopter03Camera02AudioListener.enabled = true;

                // _policeHelicopter03Camera03 enabled is true
                _policeHelicopter03Camera03.enabled = true;

                // _policeHelicopter03Camera03AudioListener enabled is true
                _policeHelicopter03Camera03AudioListener.enabled = true;

                // _policeHelicopter03AudioSource enabled is true
                _policeHelicopter03AudioSource.enabled = true; 

                // _inPoliceHelicopter03 is true
                _inPoliceHelicopter03 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _heli03Compass enabled is true
                _heli03Compass.enabled = true;

                // _heli03Compass compassEnabled is true
                _heli03Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Heli03 compass is enabled");

            } // close if not _inPoliceHelicopter03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
            // if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _interfaceHUDObject SetActive is false
                _interfaceHUDObject.SetActive(false);                  
             
            } // close if gameObject tag is Player

        } // close private void OnTriggerExit Collider other

    } // close public class PoliceHelicopter03Entry  

} // close namespace VehiclesControl
