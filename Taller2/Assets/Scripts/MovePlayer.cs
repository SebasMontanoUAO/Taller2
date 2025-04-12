using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float hSpeed;
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool isGrounded;

    private float horizontal;
    private Rigidbody2D rigidBodyPlayer;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyPlayer = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.0079f, 0.096f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        horizontal = Input.GetAxisRaw("Horizontal");
        JumpCheck();
    }

    private void FixedUpdate()
    {
        rigidBodyPlayer.velocity = new Vector2(horizontal * hSpeed, rigidBodyPlayer.velocity.y);
        CheckDirection(rigidBodyPlayer.velocity);
    }

    private void CheckDirection(Vector2 velocidad)
    {
        if (velocidad.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (velocidad.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    private void JumpCheck()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidBodyPlayer.AddForce(new Vector2(rigidBodyPlayer.velocity.x, jumpForce));
        }
    }
}
