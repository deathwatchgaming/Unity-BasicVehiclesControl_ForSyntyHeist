/*
 * File: Police Helicopter 04 Entry
 * Name: PoliceHelicopter04Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class PoliceHelicopter04Entry 
    public class PoliceHelicopter04Entry : MonoBehaviour
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

            [Tooltip("The policeHelicopter04 game object")]
            // GameObject _policeHelicopter04
            [SerializeField] private GameObject _policeHelicopter04;

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
            // bool _inPoliceHelicopter04 is false
            [SerializeField] private bool _inPoliceHelicopter04 = false;
        
        // PoliceHelicopter04Controller _policeHelicopter04Script
        private PoliceHelicopter04Controller _policeHelicopter04Script;

        // PoliceHelicopter04CamSwitch _policeHelicopter04CamScript
        private PoliceHelicopter04CamSwitch _policeHelicopter04CamScript;
        
        // Camera _policeHelicopter04Camera01
        private Camera _policeHelicopter04Camera01;

        // AudioListener _policeHelicopter04Camera01AudioListener
        private AudioListener _policeHelicopter04Camera01AudioListener;

        // Camera _policeHelicopter04Camera02
        private Camera _policeHelicopter04Camera02;

        // AudioListener _policeHelicopter04Camera02AudioListener
        private AudioListener _policeHelicopter04Camera02AudioListener;

        // Camera _policeHelicopter04Camera03
        private Camera _policeHelicopter04Camera03;

        // AudioListener _policeHelicopter04Camera03AudioListener
        private AudioListener _policeHelicopter04Camera03AudioListener;

        // AudioSource _policeHelicopter04AudioSource
        private AudioSource _policeHelicopter04AudioSource;

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

        // private void Start
        private void Start() 
        {
            // _policeHelicopter04Script is GetComponent PoliceHelicopter04Controller
            _policeHelicopter04Script = GetComponent<PoliceHelicopter04Controller>();

            // _policeHelicopter04Script enabled is false
            _policeHelicopter04Script.enabled = false;

            // _policeHelicopter04CamScript is GetComponent PoliceHelicopter04CamSwitch
            _policeHelicopter04CamScript = GetComponent<PoliceHelicopter04CamSwitch>();

            // _policeHelicopter04CamScript enabled is false
            _policeHelicopter04CamScript.enabled = false;

            // _policeHelicopter04Camera01 is GetComponentInChildren Camera
            _policeHelicopter04Camera01 = _cameras[0].GetComponentInChildren<Camera>();

            // _policeHelicopter04Camera01 enabled is false
            _policeHelicopter04Camera01.enabled = false;

            // _policeHelicopter04Camera01AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter04Camera01AudioListener = _cameras[0].GetComponentInChildren<AudioListener>();

            // _policeHelicopter04Camera01AudioListener enabled is false
            _policeHelicopter04Camera01AudioListener.enabled = false;

            // _policeHelicopter04Camera02 is GetComponentInChildren Camera
            _policeHelicopter04Camera02 = _cameras[1].GetComponentInChildren<Camera>();

            // _policeHelicopter04Camera02 enabled is false
            _policeHelicopter04Camera02.enabled = false;

            // _policeHelicopter04Camera02AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter04Camera02AudioListener = _cameras[1].GetComponentInChildren<AudioListener>();

            // _policeHelicopter04Camera02AudioListener enabled is false
            _policeHelicopter04Camera02AudioListener.enabled = false;

            // _policeHelicopter04Camera03 is GetComponentInChildren Camera
            _policeHelicopter04Camera03 = _cameras[2].GetComponentInChildren<Camera>();

            // _policeHelicopter04Camera03 enabled is false
            _policeHelicopter04Camera03.enabled = false;

            // _policeHelicopter04Camera03AudioListener is GetComponentInChildren AudioListener
            _policeHelicopter04Camera03AudioListener = _cameras[2].GetComponentInChildren<AudioListener>();

            // _policeHelicopter04Camera03AudioListener enabled is false
            _policeHelicopter04Camera03AudioListener.enabled = false;

            // _policeHelicopter04AudioSource
            _policeHelicopter04AudioSource = GetComponent<AudioSource>();

            // _policeHelicopter04AudioSource enabled is false
            _policeHelicopter04AudioSource.enabled = false;            

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceHelicopter04_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceHelicopter04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false); 

            // GameObject _interfaceHUDObject is FindInActiveObjectByName PoliceHelicopter04_HUD 
            GameObject _interfaceHUDObject = FindInActiveObjectByName("PoliceHelicopter04_HUD");
            
            // _interfaceHUDObject SetActive is false
            _interfaceHUDObject.SetActive(false); 

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceHelicopter04 and Input GetKey KeyCode _exitKey
            if (_inPoliceHelicopter04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeHelicopter04Script enabled is false
                _policeHelicopter04Script.enabled = false;

                // _policeHelicopter04CamScript enabled is false
                _policeHelicopter04CamScript.enabled = false;                
                
                // _policeHelicopter04Camera01 enabled is false
                _policeHelicopter04Camera01.enabled = false;

                // _policeHelicopter04Camera01AudioListener enabled is false
                _policeHelicopter04Camera01AudioListener.enabled = false;

                // _policeHelicopter04Camera02 enabled is false
                _policeHelicopter04Camera02.enabled = false;

                // _policeHelicopter04Camera02AudioListener enabled is false
                _policeHelicopter04Camera02AudioListener.enabled = false;

                // _policeHelicopter04Camera03 enabled is false
                _policeHelicopter04Camera03.enabled = false;

                // _policeHelicopter04Camera03AudioListener enabled is false
                _policeHelicopter04Camera03AudioListener.enabled = false;
 
                // _policeHelicopter04AudioSource enabled is false
                _policeHelicopter04AudioSource.enabled = false;          

                // _inPoliceHelicopter04 is false
                _inPoliceHelicopter04 = false;

            } // close if _inPoliceHelicopter04 and Input GetKey KeyCode _exitKey

        } // close private void Update     

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceHelicopter04 and gameObject tag is Player
            if (!_inPoliceHelicopter04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

                // _interfaceHUDObject SetActive is false
                _interfaceHUDObject.SetActive(false); 

            } // close if not _inPoliceHelicopter04 and gameObject tag is Player
            
            // if not _inPoliceHelicopter04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceHelicopter04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _interfaceHUDObject SetActive is true
                _interfaceHUDObject.SetActive(true);                

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeHelicopter04 transform
                _player.transform.parent = _policeHelicopter04.transform;

                // _policeHelicopter04Script enabled is true
                _policeHelicopter04Script.enabled = true;

                // _policeHelicopter04CamScript enabled is true
                _policeHelicopter04CamScript.enabled = true;                

                // _policeHelicopter04Camera01 enabled is true                    
                _policeHelicopter04Camera01.enabled = true;

                // _policeHelicopter04Camera01AudioListener enabled is true
                _policeHelicopter04Camera01AudioListener.enabled = true;

                // _policeHelicopter04Camera02 enabled is true
                _policeHelicopter04Camera02.enabled = true;

                // _policeHelicopter04Camera02AudioListener enabled is true
                _policeHelicopter04Camera02AudioListener.enabled = true;

                // _policeHelicopter04Camera03 enabled is true
                _policeHelicopter04Camera03.enabled = true;

                // _policeHelicopter04Camera03AudioListener enabled is true
                _policeHelicopter04Camera03AudioListener.enabled = true;

                // _policeHelicopter04AudioSource enabled is true
                _policeHelicopter04AudioSource.enabled = true; 

                // _inPoliceHelicopter04 is true
                _inPoliceHelicopter04 = true;

            } // close if not _inPoliceHelicopter04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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

    } // close public class PoliceHelicopter04Entry  

} // close namespace VehiclesControl