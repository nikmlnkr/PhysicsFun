using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;

    public Animator animator;

    public int jumpForce = 40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce));
            animator.SetInteger("isJumping", 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetInteger("isJumping", 0);
    }
}
