/*
 * File: Police Helicopter 02 Entry
 * Name: PoliceHelicopter02Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 6+
 */

// using
using UnityEngine;
using System.Collections;
using NavigationControl;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class PoliceHelicopter02Entry 
    public class PoliceHelicopter02Entry : MonoBehaviour
    {
        // Input Customizations
        [Header("Input Customizations")] 

            [Tooltip("The vehicle entry key code")]
            // KeyCode _enterKey
            [SerializeField] private KeyCode _enterKey = KeyCode.E;

            [Tooltip("The vehicle exit key code")]
            // KeyCode _exitKey
            [SerializeField] private KeyCode _exitKey = KeyCode.F;

        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The policeHelicopter02 game object")]
            // GameObject _policeHelicopter02
            [SerializeField] private GameObject _policeHelicopter02;

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
            // bool _inPoliceHelicopter02 is false
            [SerializeField] private bool _inPoliceHelicopter02 = false;
        
        // PoliceHelicopter02Controller _policeHelicopter02Script
        private PoliceHelicopter02Controller _policeHelicopter02Script;

        // PoliceHelicopter02CamSwitch _policeHelicopter02CamScript
        private PoliceHelicopter02CamSwitch _policeHelicopter02CamScript;
        
        // Camera _policeHelicopter02Camera01
        private Camera _policeHelicopter02Camera01;

        // AudioListener _policeHelicopter02Camera01AudioListener
        private AudioListener _policeHelicopter02Camera01AudioListener;

        // Camera _policeHelicopter02Camera02
        private Camera _policeHelicopter02Camera02;

        // AudioListener _policeHelicopter02Camera02AudioListener
        private AudioListener _policeHelicopter02Camera02AudioListener;

        // Camera _policeHelicopter02Camera03
        private Camera _policeHelicopter02Camera03;

        // AudioListener _policeHelicopter02Camera03AudioListener
        private AudioListener _policeHelicopter02Camera03AudioListener;

        // AudioSource _policeHelicopter02AudioSource
        private AudioSource _policeHelicopter02AudioSource;

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;

        [Tooltip("The cameras ie: 0: Rear Camera & 1: Cockpit Camera")]
        // private Camera[] _cameras
        [SerializeField] private Camera[] _cameras;

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

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The police helicopter 02 compass")]
            // PoliceHelicopter02Compass _heli02Compass
            [SerializeField] private PoliceHelicopter02Compass _heli02Compass;  

        //public static PoliceHelicopter02Entry _policeHelicopter02Entry;

        // private void Start
        private void Start() 
        {
            //_policeHelicopter02Entry = this;

            // _policeHelicopter02Script is GetComponent PoliceHelicopter02Controller
            _policeHelicopter02Script = GetComponent<PoliceHelicopter02Controller>();

            // _policeHelicopter02Script enabled is false
            _policeHelicopter02Script.enabled = false;

            // _policeHelicopter02CamScript is GetComponent PoliceHelicopter02CamSwitch
            _policeHelicopter02CamScript = GetComponent<PoliceHelicopter02CamSwitch>();

            // _policeHelicopter02CamScript enabled is false
            _policeHelicopter02CamScript.enabled = false;

            // _policeHelicopter02Camera01 is GetComponentInChildren Camera
            _policeHelicopter02Camera01 = _cameras[0].GetComponentInChildren<Camera>();

            // _policeHelicopter02Camera01 enabled is false
            _policeHelicopter02Camera01.enabled = false;

            // _policeHelicopter02Camera01AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter02Camera01AudioListener = _cameras[0].GetComponentInChildren<AudioListener>();

            // _policeHelicopter02Camera01AudioListener enabled is false
            _policeHelicopter02Camera01AudioListener.enabled = false;

            // _policeHelicopter02Camera02 is GetComponentInChildren Camera
            _policeHelicopter02Camera02 = _cameras[1].GetComponentInChildren<Camera>();

            // _policeHelicopter02Camera02 enabled is false
            _policeHelicopter02Camera02.enabled = false;

            // _policeHelicopter02Camera02AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter02Camera02AudioListener = _cameras[1].GetComponentInChildren<AudioListener>();

            // _policeHelicopter02Camera02AudioListener enabled is false
            _policeHelicopter02Camera02AudioListener.enabled = false;

            // _policeHelicopter02Camera03 is GetComponentInChildren Camera
            _policeHelicopter02Camera03 = _cameras[2].GetComponentInChildren<Camera>();

            // _policeHelicopter02Camera03 enabled is false
            _policeHelicopter02Camera03.enabled = false;

            // _policeHelicopter02Camera03AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter02Camera03AudioListener = _cameras[2].GetComponentInChildren<AudioListener>();

            // _policeHelicopter02Camera03AudioListener enabled is false
            _policeHelicopter02Camera03AudioListener.enabled = false;

            // _policeHelicopter02AudioSource
            _policeHelicopter02AudioSource = GetComponent<AudioSource>();

            // _policeHelicopter02AudioSource enabled is false
            _policeHelicopter02AudioSource.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject 
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceHelicopter02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false); 

            // GameObject _interfaceHUDObject 
            GameObject _interfaceHUDObject = FindInActiveObjectByName("PoliceHelicopter02_HUD");
            
            // _interfaceHUDObject SetActive is false
            _interfaceHUDObject.SetActive(false); 

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _heli02Compass enabled is false
            _heli02Compass.enabled = false;

            // _heli02Compass compassEnabled is false
            _heli02Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Heli02 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceHelicopter02 and Input GetKey KeyCode _exitKey
            if (_inPoliceHelicopter02 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeHelicopter02Script enabled is false
                _policeHelicopter02Script.enabled = false;

                // _policeHelicopter02CamScript enabled is false
                _policeHelicopter02CamScript.enabled = false;                
                
                // _policeHelicopter02Camera01 enabled is false
                _policeHelicopter02Camera01.enabled = false;

                // _policeHelicopter02Camera01AudioListener enabled is false
                _policeHelicopter02Camera01AudioListener.enabled = false;

                // _policeHelicopter02Camera02 enabled is false
                _policeHelicopter02Camera02.enabled = false;

                // _policeHelicopter02Camera02AudioListener enabled is false
                _policeHelicopter02Camera02AudioListener.enabled = false;

                // _policeHelicopter02Camera03 enabled is false
                _policeHelicopter02Camera03.enabled = false;

                // _policeHelicopter02Camera03AudioListener enabled is false
                _policeHelicopter02Camera03AudioListener.enabled = false;

                // _policeHelicopter02AudioSource enabled is false
                _policeHelicopter02AudioSource.enabled = false;          

                // _inPoliceHelicopter02 is false
                _inPoliceHelicopter02 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _heli02Compass enabled is false
                _heli02Compass.enabled = false;

                // _heli02Compass compassEnabled is false
                _heli02Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Heli02 compass is disabled");

            } // close if _inPoliceHelicopter02 and Input GetKey KeyCode _exitKey

        } // close private void Update     

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceHelicopter02 and gameObject tag is Player
            if (!_inPoliceHelicopter02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

                // _interfaceHUDObject SetActive is false
                _interfaceHUDObject.SetActive(false); 

            } // close if not _inPoliceHelicopter02 and gameObject tag is Player
            
            // if not _inPoliceHelicopter02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceHelicopter02 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _interfaceHUDObject SetActive is true
                _interfaceHUDObject.SetActive(true);                

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeHelicopter02 transform
                _player.transform.parent = _policeHelicopter02.transform;

                // _policeHelicopter02Script enabled is true
                _policeHelicopter02Script.enabled = true;

                // _policeHelicopter02CamScript enabled is true
                _policeHelicopter02CamScript.enabled = true;                

                // _policeHelicopter02Camera01 enabled is true                    
                _policeHelicopter02Camera01.enabled = true;

                // _policeHelicopter02Camera01AudioListener enabled is true
                _policeHelicopter02Camera01AudioListener.enabled = true;

                // _policeHelicopter02Camera02 enabled is true
                _policeHelicopter02Camera02.enabled = true;

                // _policeHelicopter02Camera02AudioListener enabled is true
                _policeHelicopter02Camera02AudioListener.enabled = true;

                // _policeHelicopter02Camera03 enabled is true
                _policeHelicopter02Camera03.enabled = true;

                // _policeHelicopter02Camera03AudioListener enabled is true
                _policeHelicopter02Camera03AudioListener.enabled = true;

                // _policeHelicopter02AudioSource enabled is true
                _policeHelicopter02AudioSource.enabled = true; 

                // _inPoliceHelicopter02 is true
                _inPoliceHelicopter02 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _heli02Compass enabled is true
                _heli02Compass.enabled = true;

                // _heli02Compass compassEnabled is true
                _heli02Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Heli02 compass is enabled");

            } // close if not _inPoliceHelicopter02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

    } // close public class PoliceHelicopter02Entry  

} // close namespace VehiclesControl
