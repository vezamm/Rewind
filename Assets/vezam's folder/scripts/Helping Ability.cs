using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering.Universal;


public class HelpingAbility : MonoBehaviour
{
        
        public Camera secondaryCamera; // Assign the secondary camera for highlights
        public PostProcessVolume grayscaleVolume;
        private bool isEagleVisionActive = false;

        void Update()
        {
            grayscaleVolume=gameObject.GetComponent<PostProcessVolume>();
            // Check for ability activation input (for example, pressing "E")
            if (Input.GetKeyDown(KeyCode.R))
            {
                ToggleEagleVision();
            }
        }

        void ToggleEagleVision()
        {
            isEagleVisionActive = !isEagleVisionActive;

            // Enable/disable grayscale effect
            grayscaleVolume.enabled = isEagleVisionActive;

            // Enable/disable secondary camera for highlighted objects
            secondaryCamera.gameObject.SetActive(isEagleVisionActive);
            secondaryCamera.enabled = isEagleVisionActive;
        }
    }
