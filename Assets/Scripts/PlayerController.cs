using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction playerMovement;
    private Vector2 moveInput;
    private Rigidbody playerRB;
    public float speed;
    public float turnSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Logic for movement towards caster. Increasing score through game manager as player gets closer. Actually put that there, not here.
        movePlayer();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Logic for collision with the swords
        if ( other.CompareTag("Sword"))
        {
            //UI Logic for loss of health based on where the player is hit.
        }
    }
    private void movePlayer()
    {
        // Get current movement input
        moveInput = playerMovement.ReadValue<Vector2>();

        // Move player forward or back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Turn sideways
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveInput.x);
    }
}
