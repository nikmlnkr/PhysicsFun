using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    public float moveSpeed = 8f;
    public float inertia = 0.9f; // Between 0 (no slide) and 1 (very slippery)

    private Rigidbody2D rb;
    private float moveInput;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }


    private void FixedUpdate()
    {
        // Get current velocity
        Vector2 currentVelocity = rb.linearVelocity;

        if (moveInput != 0)
        {
            // Immediate input-based velocity change
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, currentVelocity.y);
        }
        else
        {
            // Apply inertia when no key is pressed
            rb.linearVelocity = new Vector2(currentVelocity.x * inertia, currentVelocity.y);

            // Optional: stop when slow enough
            if (Mathf.Abs(rb.linearVelocity.x) < 0.05f)
            {
                rb.linearVelocity = new Vector2(0f, currentVelocity.y);
            }
        }
    }
}
