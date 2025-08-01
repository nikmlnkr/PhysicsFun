using UnityEngine;

public class PlayerCollisionSample : MonoBehaviour
{
    //Collision:
    //Enter
    //Exit
    //Stay

    //Trigger Collision:
    //Enter
    //Exit
    //Stay


    void OnCollisionEnter(Collision c)
    {
        print("Enter: " + c.gameObject.name);
    }

    private void OnCollisionExit(Collision col)
    {
        print("Exit: " + col.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Entering trigger: " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exiting trigger: " + other.gameObject.name);
    }

}
