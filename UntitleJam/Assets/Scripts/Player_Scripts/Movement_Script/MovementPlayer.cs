using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [Header ("PlayerComponets")]
    public Rigidbody2D rb;

    [Header("Settings")]
    [SerializeField]
    float speed = 1;

    bool isJumping = false;

    public void MovePlayer(Vector2 axisXY)
    {
        rb.velocity = axisXY * -speed * Time.deltaTime;
    }

    public void JumpPlayer()
    {
        if (isJumping == false)
        {
            if (rb.gravityScale > 0)
                rb.gravityScale = 1;
            else
                rb.gravityScale = -1;

            isJumping = true;
            rb.gravityScale *= -2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        if (collision.gameObject.CompareTag("Roof"))
        {
            isJumping = false;
        }

    }

}
