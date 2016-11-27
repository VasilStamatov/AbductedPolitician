using UnityEngine;
using System.Collections;

/// <summary>
/// Movement controls and animation handling
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    float speed = 4.0f;
    float jumpPower = 300.0f;
    public bool isJumping = false;
    bool isWalkingRight = false;
    bool isWalkingLeft = false;
    int jumpCount = 0;
    Rigidbody2D rb2d;
    Animator anim;

    public void setJump(int _jumpCount) { this.jumpCount = _jumpCount; }

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpCount < 2 && Input.GetKeyDown(KeyCode.W))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0.0f);
            Debug.Log("Player Jumped!");
            rb2d.AddForce(Vector2.up * jumpPower);
            jumpCount++;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.transform.Translate(Vector3.right * speed * Time.deltaTime);
            isWalkingRight = true;
            isWalkingLeft = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.transform.Translate(Vector3.left * speed * Time.deltaTime);
            isWalkingRight = false;
            isWalkingLeft = true;
        }
        else
        {
            rb2d.velocity = new Vector2(0.0f, rb2d.velocity.y);
            isWalkingRight = false;
            isWalkingLeft = false;
        }
        anim.SetBool("isJumping", isJumping);
        anim.SetBool("isWalkingRight", isWalkingRight);
        anim.SetBool("isWalkingLeft", isWalkingLeft);
    }
}
