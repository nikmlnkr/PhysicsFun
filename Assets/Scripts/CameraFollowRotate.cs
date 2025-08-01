using UnityEngine;

public class CameraFollowRotate : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody; // Assign this to the player GameObject (if rotating the body too)

    float xRotation = 0f;

    void Start()
    {
        // Lock the cursor to the center and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse movement
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Vertical look (clamp the up/down angle)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Apply vertical rotation (looking up/down)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Apply horizontal rotation to player body (turning left/right)
        if (playerBody != null)
        {
            playerBody.Rotate(Vector3.up * mouseX);
        }
        else
        {
            // If no body assigned, rotate the camera itself
            transform.Rotate(Vector3.up * mouseX);
        }
    }
}
