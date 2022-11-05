/*
 * Zach Wilson
 * Assignment 5B
 * This is the mouse look script which handles the rotation of the player and camera with mouse input
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //get mouse input and assign it to two floats
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotate player gameobject with horizontal mouse input
        player.transform.Rotate(Vector3.up * mouseX);

        //rotate camera around the x axis with vertical mouse input
        verticalLookRotation -= mouseY;

        //limit the vertical rotation with clamp
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        //apply rotation to the camera based on the clamped output
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
}
