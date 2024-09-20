/*
 * File: Swat Van 03 Entry
 * Name: SwatVan03Entry.cs
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

    // public class SwatVan03Entry 
    public class SwatVan03Entry : MonoBehaviour
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

            [Tooltip("The swatVan03 game object")]
            // GameObject _swatVan03
            [SerializeField] private GameObject _swatVan03;

            [Tooltip("The player game object")]
            // GameObject _player
            [SerializeField] private GameObject _player;

            [Tooltip("The interface text game object")]
            // GameObject _interfaceTextObject
            [SerializeField] private GameObject _interfaceTextObject;
        
        // Active State
        [Header("Active State")]

            [Tooltip("The active state bool")]
            // bool _inSwatVan03 is false
            [SerializeField] private bool _inSwatVan03 = false;
        
        // SwatVan03Controller _swatVan03Script
        private SwatVan03Controller _swatVan03Script;

        // Camera _swatVan03Camera
        private Camera _swatVan03Camera;

        // AudioListener _swatVan03CameraAudioListener
        private AudioListener _swatVan03CameraAudioListener; 

        // Rigidbody _rigidbody
        private Rigidbody _rigidbody; 

        // private void Start
        private void Start() 
        {
            // _swatVan03Script is GetComponent SwatVan03Controller
            _swatVan03Script = GetComponent<SwatVan03Controller>();

            // _swatVan03Script enabled is false
            _swatVan03Script.enabled = false;
            
            // _swatVan03Script is GetComponentInChildren Camera
            _swatVan03Camera = GetComponentInChildren<Camera>();

            // _swatVan03Camera enabled is false
            _swatVan03Camera.enabled = false;
           
            // _swatVan03CameraAudioListener is GetComponentInChildren AudioListener
            _swatVan03CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _swatVan03CameraAudioListener enabled is false
            _swatVan03CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // _interfaceTextObject is GameObject Find SwatVan03_EntryKey
            _interfaceTextObject = GameObject.Find("SwatVan03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSwatVan03 and Input GetKey KeyCode _exitKey
            if (_inSwatVan03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _swatVan03Script enabled is false
                _swatVan03Script.enabled = false;

                // _swatVan03Camera enabled is false
                _swatVan03Camera.enabled = false;

                // _swatVan03CameraAudioListener enabled is false
                _swatVan03CameraAudioListener.enabled = false; 

                // _inSwatVan03 is false
                _inSwatVan03 = false;

            } // close if _inSwatVan03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSwatVan03 and gameObject tag is Player
            if (!_inSwatVan03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSwatVan03 and gameObject tag is Player
            
            // if not _inSwatVan03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSwatVan03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _swatVan03 transform
                _player.transform.parent = _swatVan03.transform;

                // _swatVan03Script enabled is true
                _swatVan03Script.enabled = true;

                // _swatVan03Camera enabled is true
                _swatVan03Camera.enabled = true;

                // _swatVan03CameraAudioListener enabled is true
                _swatVan03CameraAudioListener.enabled = true; 

                // _inSwatVan03 is true
                _inSwatVan03 = true;

            } // close if not _inSwatVan03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SwatVan03Entry  

} // close namespace VehiclesControl
