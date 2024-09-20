/*
 * File: Police Charger 04 Entry
 * Name: PoliceCharger04Entry.cs
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

    // public class PoliceCharger04Entry 
    public class PoliceCharger04Entry : MonoBehaviour
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
            // GameObject _policeCharger04
            [SerializeField] private GameObject _policeCharger04;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inPoliceCharger04 is false
            [SerializeField] private bool _inPoliceCharger04 = false;
        
        // PoliceCharger04Controller _policeCharger04Script
        private PoliceCharger04Controller _policeCharger04Script;
        
        // Camera _policeCharger04Camera
        private Camera _policeCharger04Camera;

        // AudioListener _policeCharger04CameraAudioListener
        private AudioListener _policeCharger04CameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody;
        
        // private void Start
        private void Start() 
        {
            // _policeCharger04Script is GetComponent PoliceCharger04Controller
            _policeCharger04Script = GetComponent<PoliceCharger04Controller>();

            // _policeCharger04Script enabled is false
            _policeCharger04Script.enabled = false;
            
            // _policeCharger04Camera is GetComponentInChildren Camera
            _policeCharger04Camera = GetComponentInChildren<Camera>();
            
            // _policeCharger04Camera enabled is false
            _policeCharger04Camera.enabled = false;
           
            // _policeCharger04CameraAudioListener is GetComponentInChildren AudioListener
            _policeCharger04CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCharger04CameraAudioListener enabled is false
            _policeCharger04CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find PoliceCharger04_EntryKey
            _interfaceTextObject = GameObject.Find("PoliceCharger04_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCharger04 and Input GetKey KeyCode _exitKey
            if (_inPoliceCharger04 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCharger04Script enabled is false
                _policeCharger04Script.enabled = false;
                
                // _policeCharger04Camera enabled is false
                _policeCharger04Camera.enabled = false;

                // _policeCharger04CameraAudioListener enabled is false
                _policeCharger04CameraAudioListener.enabled = false;

                // _inPoliceCharger04 is false
                _inPoliceCharger04 = false;

            } // close if _inPoliceCharger04 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCharger04 and gameObject tag is Player
            if (!_inPoliceCharger04 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCharger04 and gameObject tag is Player
            
            // if not _inPoliceCharger04 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCharger04 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCharger04 transform
                _player.transform.parent = _policeCharger04.transform;

                // _policeCharger04Script enabled is true
                _policeCharger04Script.enabled = true;
                
                // _policeCharger04Camera enabled is true
                _policeCharger04Camera.enabled = true;

                // _policeCharger04CameraAudioListener enabled is true
                _policeCharger04CameraAudioListener.enabled = true;

                // _inPoliceCharger04 is true
                _inPoliceCharger04 = true;

            } // close if not _inPoliceCharger04 and gameObject tag is Player and Input GetKey KeyCode _enterKey

        } // close private void OnTriggerStay Collider other
        
        // private void OnTriggerExit Collider other
        private void OnTriggerExit(Collider other)
        {
            // if gameObject tag is Player
            if (other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);
                
                // StartCoroutine RigidbodySleep
                StartCoroutine(RigidbodySleep(0.000001f)); 

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
        
    } // close public class PoliceCharger04Entry  

} // close namespace VehiclesControl
