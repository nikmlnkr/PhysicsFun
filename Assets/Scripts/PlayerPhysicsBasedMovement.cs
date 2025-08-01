using UnityEngine;

public class PlayerPhysicsBasedMovement : MonoBehaviour
{
    public float jumpForce = 5;

    bool isJumping = false;
    int jumpTracker = 0;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping && jumpTracker < 2)
            {
                rb.AddForce(new Vector3(0, jumpForce, 0));
                jumpTracker++;
            }
            if (jumpTracker > 2)
                jumpTracker = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }

    void OnCollisionExit(Collision collision)
    {
        isJumping = true;
    }
}
