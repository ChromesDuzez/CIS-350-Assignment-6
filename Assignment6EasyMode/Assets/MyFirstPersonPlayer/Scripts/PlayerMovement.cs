/*
 * Zach Wilson
 * Assignment 5B
 * This is the player movement script which handles the input for the player character's movement
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables for player movement
    public CharacterController controller;
    public float speed = 12f;
    public float jumpHeight = 3f;

    //variables for gravity
    public Vector3 velocity;
    public float gravity = -9.81f;
    public float gravityMultiplier = 2f;

    //variables for onGound check
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    void Awake() { gravity *= gravityMultiplier; }

    void Update()
    {
        //check if the player is on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //check for directional player movement input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //application of player input
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //check for jump player movement input and apply it to the velocity y
        if (Input.GetButtonDown("Jump") && isGrounded && !Globals.objectiveComplete)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


    }
}
