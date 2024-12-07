using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;        // Movement speed
    public float jumpHeight = 2f;       // Jump height
    public float mouseSensitivity = 2f; // Mouse sensitivity for looking around
    public float gravity = -9.81f;      // Gravity to apply to the player
    public Transform playerCamera;      // Reference to the camera (drag the player camera here)
    
    private CharacterController controller;
    private Vector3 velocity;
    private float xRotation = 0f;
    private bool isGrounded;

    void Start()
    {
        // Get the CharacterController component attached to the player
        controller = GetComponent<CharacterController>();

        // Lock the cursor to the center of the screen and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Check if the player is grounded
        isGrounded = controller.isGrounded;

        // Reset vertical velocity when grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // A small downward force to keep the player grounded
        }

        // Call methods for movement, looking around, and jumping
        MovePlayer();
        LookAround();
        Jump();
        
        // Apply gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void MovePlayer()
    {
        // Get input for movement (WASD keys)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Create a movement vector based on input and player's facing direction
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Move the player with CharacterController
        controller.Move(move * moveSpeed * Time.deltaTime);
    }

    void LookAround()
    {
        // Get mouse input for looking around
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Adjust camera rotation around the X axis (up and down)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limit vertical rotation to prevent flipping over

        // Apply rotation to the camera
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the player body horizontally
        transform.Rotate(Vector3.up * mouseX);
    }

    void Jump()
    {
        // Check if the jump button (space) is pressed and the player is grounded
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Apply jump velocity using the jump height and gravity formula
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}