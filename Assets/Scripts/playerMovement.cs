using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody rb;
    private bool isGrounded;
    public LayerMask groundLayer;
    public GameObject playerCamera;

    float mouseX, mouseY;
    public float mouseSensitivity = 100f;
    float xRotation = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Check for ground
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f, groundLayer);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        if (Input.GetKey(KeyCode.A))
        {
            movement = new Vector3(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement = new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            movement = new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement = new Vector3(0, 0, -speed);
        }

        // Apply the movement to the Rigidbody
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // Mouse Look
        //mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime;
        //mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}