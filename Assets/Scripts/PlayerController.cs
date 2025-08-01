using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int speed = 2;

    public GameManager gm;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "coin")
        {
            gm.score++;
            Destroy(collision.gameObject);

            if(gm.score == 4)
            {
                SceneManager.LoadScene("game");
            }
        }

        if(collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("game");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coin")
        {
            gm.score++;
            Destroy(other.gameObject);

            if (gm.score == 4)
            {
                SceneManager.LoadScene("game");
            }
        }

    }
}
