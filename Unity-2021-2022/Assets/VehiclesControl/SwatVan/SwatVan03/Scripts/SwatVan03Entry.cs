/*
 * File: Swat Van 03 Entry
 * Name: SwatVan03Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+
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
            
        // Rigidbody Sleep
        [Header("Rigidbody Sleep")]

            [Tooltip("The rigidBody sleep wait for seconds duration")]
            // float duration is 0.0001
            [SerializeField] private float duration = 0.0001f; 
        
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
            
            [Tooltip("The swat van 03 compass")]
            // SwatVan03Compass _swatVan03Compass
            [SerializeField] private SwatVan03Compass _swatVan03Compass;  

        //public static SwatVan03Entry _swatVan03Entry;

        // private void Start
        private void Start() 
        {
            //_swatVan03Entry = this;

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

            // GameObject _interfaceTextObject is FindInActiveObjectByName SwatVan03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SwatVan03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _swatVan03Compass enabled is false
            _swatVan03Compass.enabled = false;

            // _swatVan03Compass compassEnabled is false
            _swatVan03Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SwatVan03 compass is disabled");

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

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _swatVan03Compass enabled is false
                _swatVan03Compass.enabled = false;

                // _swatVan03Compass compassEnabled is false
                _swatVan03Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SwatVan03 compass is disabled");

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

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _swatVan03Compass enabled is true
                _swatVan03Compass.enabled = true;

                // _swatVan03Compass compassEnabled is true
                _swatVan03Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SwatVan03 compass is enabled");

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
        
    } // close public class SwatVan03Entry  

} // close namespace VehiclesControl
