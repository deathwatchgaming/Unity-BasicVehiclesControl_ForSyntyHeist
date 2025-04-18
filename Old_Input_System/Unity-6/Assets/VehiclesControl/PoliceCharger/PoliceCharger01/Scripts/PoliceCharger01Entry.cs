/*
 * File: Police Charger 01 Entry
 * Name: PoliceCharger01Entry.cs
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

    // public class PoliceCharger01Entry 
    public class PoliceCharger01Entry : MonoBehaviour
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

            [Tooltip("The police charger game object")]
            // GameObject _policeCharger01
            [SerializeField] private GameObject _policeCharger01;

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
            // bool _inPoliceCharger01 is false
            [SerializeField] private bool _inPoliceCharger01 = false;
        
        // PoliceCharger01Controller _policeCharger01Script
        private PoliceCharger01Controller _policeCharger01Script;
        
        // Camera _policeCharger01Camera
        private Camera _policeCharger01Camera;

        // AudioListener _policeCharger01CameraAudioListener
        private AudioListener _policeCharger01CameraAudioListener; 

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

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The police charger 01 compass")]
            // PoliceCharger01Compass _charger01Compass
            [SerializeField] private PoliceCharger01Compass _charger01Compass;  

        //public static PoliceCharger01Entry _policeCharger01Entry;      
                
        // private void Start
        private void Start() 
        {
            //_policeCharger01Entry = this;

            // _policeCharger01Script is GetComponent PoliceCharger01Controller
            _policeCharger01Script = GetComponent<PoliceCharger01Controller>();

            // _policeCharger01Script enabled is false
            _policeCharger01Script.enabled = false;
            
            // _policeCharger01Camera is GetComponentInChildren Camera
            _policeCharger01Camera = GetComponentInChildren<Camera>();
            
            // _policeCharger01Camera enabled is false
            _policeCharger01Camera.enabled = false;
           
            // _policeCharger01CameraAudioListener is GetComponentInChildren AudioListener
            _policeCharger01CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCharger01CameraAudioListener enabled is false
            _policeCharger01CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceCharger01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceCharger01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false); 

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _charger01Compass enabled is false
            _charger01Compass.enabled = false;

            // _charger01Compass compassEnabled is false
            _charger01Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The Charger01 compass is disabled");

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCharger01 and Input GetKey KeyCode _exitKey
            if (_inPoliceCharger01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCharger01Script enabled is false
                _policeCharger01Script.enabled = false;
                
                // _policeCharger01Camera enabled is false
                _policeCharger01Camera.enabled = false;

                // _policeCharger01CameraAudioListener enabled is false
                _policeCharger01CameraAudioListener.enabled = false;

                // _inPoliceCharger01 is false
                _inPoliceCharger01 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _charger01Compass enabled is false
                _charger01Compass.enabled = false;

                // _charger01Compass compassEnabled is false
                _charger01Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Charger01 compass is disabled");

            } // close if _inPoliceCharger01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCharger01 and gameObject tag is Player
            if (!_inPoliceCharger01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCharger01 and gameObject tag is Player
            
            // if not _inPoliceCharger01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCharger01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCharger01 transform
                _player.transform.parent = _policeCharger01.transform;

                // _policeCharger01Script enabled is true
                _policeCharger01Script.enabled = true;
                
                // _policeCharger01Camera enabled is true
                _policeCharger01Camera.enabled = true;

                // _policeCharger01CameraAudioListener enabled is true
                _policeCharger01CameraAudioListener.enabled = true;

                // _inPoliceCharger01 is true
                _inPoliceCharger01 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _charger01Compass enabled is true
                _charger01Compass.enabled = true;

                // _charger01Compass compassEnabled is true
                _charger01Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Charger01 compass is enabled");
 
            } // close if not _inPoliceCharger01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class PoliceCharger01Entry  

} // close namespace VehiclesControl
