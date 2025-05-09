/*
 * File: Swat Van 02 Entry (New Input System)
 * Name: SwatVan02Entry.cs
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

    // public class SwatVan02Entry 
    public class SwatVan02Entry : MonoBehaviour
    {  
        // Game Objects
        [Header("Game Objects")]

            [Tooltip("The swatVan02 game object")]
            // GameObject _swatVan02
            [SerializeField] private GameObject _swatVan02;

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
            // bool _inSwatVan02 is false
            [SerializeField] private bool _inSwatVan02 = false;

        // Compass
        [Header("Compass")]

            [Tooltip("The player compass")]
            // PlayerCompass _playerCompass
            [SerializeField] private PlayerCompass _playerCompass;
            
            [Tooltip("The swat van 02 compass")]
            // SwatVan02Compass _swatVan02Compass
            [SerializeField] private SwatVan02Compass _swatVan02Compass;

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

        // SwatVan02Controller _swatVan02Script
        private SwatVan02Controller _swatVan02Script;

        // Camera _swatVan02Camera
        private Camera _swatVan02Camera;

        // AudioListener _swatVan02CameraAudioListener
        private AudioListener _swatVan02CameraAudioListener; 

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

        //public static SwatVan02Entry _swatVan02Entry;

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
            //_swatVan02Entry = this;

            // _swatVan02Script is GetComponent SwatVan02Controller
            _swatVan02Script = GetComponent<SwatVan02Controller>();

            // _swatVan02Script enabled is false
            _swatVan02Script.enabled = false;
            
            // _swatVan02Script is GetComponentInChildren Camera
            _swatVan02Camera = GetComponentInChildren<Camera>();

            // _swatVan02Camera enabled is false
            _swatVan02Camera.enabled = false;
           
            // _swatVan02CameraAudioListener is GetComponentInChildren AudioListener
            _swatVan02CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _swatVan02CameraAudioListener enabled is false
            _swatVan02CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SwatVan02_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SwatVan02_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

            // Compass

            // _playerCompass enabled is true
            _playerCompass.enabled = true;

            // _playerCompass compassEnabled is true
            _playerCompass.compassEnabled = true;

            // Debug Log
            //Debug.Log("The Player compass is enabled");

            // _swatVan02Compass enabled is false
            _swatVan02Compass.enabled = false;

            // _swatVan02Compass compassEnabled is false
            _swatVan02Compass.compassEnabled = false;

            // Debug Log
            //Debug.Log("The SwatVan02 compass is disabled");            

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
                        
            // if _inSwatVan02 and Input GetKey KeyCode _exitKey
            if (_inSwatVan02 && _exitButton == true)
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _swatVan02Script enabled is false
                _swatVan02Script.enabled = false;

                // _swatVan02Camera enabled is false
                _swatVan02Camera.enabled = false;

                // _swatVan02CameraAudioListener enabled is false
                _swatVan02CameraAudioListener.enabled = false; 

                // _inSwatVan02 is false
                _inSwatVan02 = false;

                // Compass

                // _playerCompass enabled is true
                _playerCompass.enabled = true;

                // _playerCompass compassEnabled is true 
                _playerCompass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The Player compass is enabled");

                // _swatVan02Compass enabled is false
                _swatVan02Compass.enabled = false;

                // _swatVan02Compass compassEnabled is false
                _swatVan02Compass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The SwatVan02 compass is disabled");

            } // close if _inSwatVan02 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSwatVan02 and gameObject tag is Player
            if (!_inSwatVan02 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSwatVan02 and gameObject tag is Player
            
            // if not _inSwatVan02 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSwatVan02 && other.gameObject.tag == "Player" && _enterButton == true)
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _swatVan02 transform
                _player.transform.parent = _swatVan02.transform;

                // _swatVan02Script enabled is true
                _swatVan02Script.enabled = true;

                // _swatVan02Camera enabled is true
                _swatVan02Camera.enabled = true;

                // _swatVan02CameraAudioListener enabled is true
                _swatVan02CameraAudioListener.enabled = true; 

                // _inSwatVan02 is true
                _inSwatVan02 = true;

                // Compass

                // _playerCompass enabled is false
                _playerCompass.enabled = false;

                // _playerCompass compassEnabled is false
                _playerCompass.compassEnabled = false;

                // Debug Log
                //Debug.Log("The Player compass is disabled"); 

                // _swatVan02Compass enabled is true
                _swatVan02Compass.enabled = true;

                // _swatVan02Compass compassEnabled is true
                _swatVan02Compass.compassEnabled = true;

                // Debug Log
                //Debug.Log("The SwatVan02 compass is enabled");                

            } // close if not _inSwatVan02 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SwatVan02Entry  

} // close namespace VehiclesControl
