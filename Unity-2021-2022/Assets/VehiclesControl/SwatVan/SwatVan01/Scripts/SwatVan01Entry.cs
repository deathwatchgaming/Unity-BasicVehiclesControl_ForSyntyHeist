/*
 * File: Swat Van 01 Entry
 * Name: SwatVan01Entry.cs
 * Author: DeathwatchGaming
 * License: MIT
 * Unity Version(s): Unity 2021+ - 2022+ 
 */

// using
using UnityEngine;
using System.Collections;

// namespace VehiclesControl
namespace VehiclesControl
{
    // RequireComponent typeof BoxCollider
    [RequireComponent(typeof(BoxCollider))]

    // public class SwatVan01Entry 
    public class SwatVan01Entry : MonoBehaviour
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

            [Tooltip("The swatVan01 game object")]
            // GameObject _swatVan01
            [SerializeField] private GameObject _swatVan01;

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
            // bool _inSwatVan01 is false
            [SerializeField] private bool _inSwatVan01 = false;
        
        // SwatVan01Controller _swatVan01Script
        private SwatVan01Controller _swatVan01Script;

        // Camera _swatVan01Camera
        private Camera _swatVan01Camera;

        // AudioListener _swatVan01CameraAudioListener
        private AudioListener _swatVan01CameraAudioListener; 

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

        // private void Start
        private void Start() 
        {
            // _swatVan01Script is GetComponent SwatVan01Controller
            _swatVan01Script = GetComponent<SwatVan01Controller>();

            // _swatVan01Script enabled is false
            _swatVan01Script.enabled = false;
            
            // _swatVan01Script is GetComponentInChildren Camera
            _swatVan01Camera = GetComponentInChildren<Camera>();

            // _swatVan01Camera enabled is false
            _swatVan01Camera.enabled = false;
           
            // _swatVan01CameraAudioListener is GetComponentInChildren AudioListener
            _swatVan01CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _swatVan01CameraAudioListener enabled is false
            _swatVan01CameraAudioListener.enabled = false; 

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName SwatVan01_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("SwatVan01_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false);

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inSwatVan01 and Input GetKey KeyCode _exitKey
            if (_inSwatVan01 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _swatVan01Script enabled is false
                _swatVan01Script.enabled = false;

                // _swatVan01Camera enabled is false
                _swatVan01Camera.enabled = false;

                // _swatVan01CameraAudioListener enabled is false
                _swatVan01CameraAudioListener.enabled = false; 

                // _inSwatVan01 is false
                _inSwatVan01 = false;

            } // close if _inSwatVan01 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inSwatVan01 and gameObject tag is Player
            if (!_inSwatVan01 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inSwatVan01 and gameObject tag is Player
            
            // if not _inSwatVan01 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inSwatVan01 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _swatVan01 transform
                _player.transform.parent = _swatVan01.transform;

                // _swatVan01Script enabled is true
                _swatVan01Script.enabled = true;

                // _swatVan01Camera enabled is true
                _swatVan01Camera.enabled = true;

                // _swatVan01CameraAudioListener enabled is true
                _swatVan01CameraAudioListener.enabled = true; 

                // _inSwatVan01 is true
                _inSwatVan01 = true;

            } // close if not _inSwatVan01 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class SwatVan01Entry  

} // close namespace VehiclesControl
