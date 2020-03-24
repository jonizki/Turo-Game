using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    bool isGrounded;

    [SerializeField]
    Transform groundCheck;


    // Start is called before the first frame update
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        if(Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(9, rb2d.velocity.y);
            spriteRenderer.flipX = false;
        }
        else if(Input.GetKey("a") ||Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-9, rb2d.velocity.y);
            spriteRenderer.flipX = true;
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }


        if(Input.GetKey("space") && isGrounded)
        {
            rb2d.velocity = new Vector2(0, 12);
        }


    }
}
