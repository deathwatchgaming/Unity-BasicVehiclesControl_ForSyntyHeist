/*
 * File: Police Charger 03 Entry
 * Name: PoliceCharger03Entry.cs
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

    // public class PoliceCharger03Entry 
    public class PoliceCharger03Entry : MonoBehaviour
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
            // GameObject _policeCharger03
            [SerializeField] private GameObject _policeCharger03;

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
            // bool _inPoliceCharger03 is false
            [SerializeField] private bool _inPoliceCharger03 = false;
        
        // PoliceCharger03Controller _policeCharger03Script
        private PoliceCharger03Controller _policeCharger03Script;
        
        // Camera _policeCharger03Camera
        private Camera _policeCharger03Camera;

        // AudioListener _policeCharger03CameraAudioListener
        private AudioListener _policeCharger03CameraAudioListener; 

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
            // _policeCharger03Script is GetComponent PoliceCharger03Controller
            _policeCharger03Script = GetComponent<PoliceCharger03Controller>();

            // _policeCharger03Script enabled is false
            _policeCharger03Script.enabled = false;
            
            // _policeCharger03Camera is GetComponentInChildren Camera
            _policeCharger03Camera = GetComponentInChildren<Camera>();
            
            // _policeCharger03Camera enabled is false
            _policeCharger03Camera.enabled = false;
           
            // _policeCharger03CameraAudioListener is GetComponentInChildren AudioListener
            _policeCharger03CameraAudioListener = GetComponentInChildren<AudioListener>();

            // _policeCharger03CameraAudioListener enabled is false
            _policeCharger03CameraAudioListener.enabled = false;

            // _rigidbody
            _rigidbody = GetComponent<Rigidbody>();

            // GameObject _interfaceTextObject is FindInActiveObjectByName PoliceCharger03_EntryKey
            GameObject _interfaceTextObject = FindInActiveObjectByName("PoliceCharger03_EntryKey");

            // _interfaceTextObject SetActive is false
            _interfaceTextObject.SetActive(false); 

        } // close private void Start

        // Update is called once per frame

        // private void Update
        private void Update()
        {
            // if _inPoliceCharger03 and Input GetKey KeyCode _exitKey
            if (_inPoliceCharger03 && Input.GetKey(_exitKey))
            {
                // _player SetActive is true
                _player.SetActive(true);

                // _player transform parent is null
                _player.transform.parent = null;

                // _policeCharger03Script enabled is false
                _policeCharger03Script.enabled = false;
                
                // _policeCharger03Camera enabled is false
                _policeCharger03Camera.enabled = false;

                // _policeCharger03CameraAudioListener enabled is false
                _policeCharger03CameraAudioListener.enabled = false;

                // _inPoliceCharger03 is false
                _inPoliceCharger03 = false;

            } // close if _inPoliceCharger03 and Input GetKey KeyCode _exitKey

        } // close private void Update         

        // private void OnTriggerStay Collider other
        private void OnTriggerStay(Collider other)
        {
            // if not _inPoliceCharger03 and gameObject tag is Player
            if (!_inPoliceCharger03 && other.gameObject.tag == "Player")
            {
                // _interfaceTextObject SetActive is true
                _interfaceTextObject.SetActive(true);

            } // close if not _inPoliceCharger03 and gameObject tag is Player
            
            // if not _inPoliceCharger03 and gameObject tag is Player and Input GetKey KeyCode _enterKey
            if (!_inPoliceCharger03 && other.gameObject.tag == "Player" && Input.GetKey(_enterKey))
            {
                // _interfaceTextObject SetActive is false
                _interfaceTextObject.SetActive(false);

                // _player SetActive is false 
                _player.SetActive(false);

                // _player transform parent is _policeCharger03 transform
                _player.transform.parent = _policeCharger03.transform;

                // _policeCharger03Script enabled is true
                _policeCharger03Script.enabled = true;
                
                // _policeCharger03Camera enabled is true
                _policeCharger03Camera.enabled = true;

                // _policeCharger03CameraAudioListener enabled is true
                _policeCharger03CameraAudioListener.enabled = true;

                // _inPoliceCharger03 is true
                _inPoliceCharger03 = true;

            } // close if not _inPoliceCharger03 and gameObject tag is Player and Input GetKey KeyCode _enterKey

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
        
    } // close public class PoliceCharger03Entry  

} // close namespace VehiclesControl
