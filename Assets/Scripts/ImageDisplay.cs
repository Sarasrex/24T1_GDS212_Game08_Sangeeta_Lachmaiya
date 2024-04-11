using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDisplay : MonoBehaviour
{
    public GameObject imageToShow; // Reference to the image game object

    void Start()
    {
        imageToShow.SetActive(false); // Deactivate the image game object initially
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider entering the trigger is the player
        {
            imageToShow.SetActive(true); // Activate the image game object
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider exiting the trigger is the player
        {
            imageToShow.SetActive(false); // Deactivate the image game object
        }
    }
}