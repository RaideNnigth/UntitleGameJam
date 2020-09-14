using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementPlayer))]
public class InputPlayer : MonoBehaviour
{
    float axisX;
    [SerializeField]
    MovementPlayer movementPlayer;

    void Update()
    {
        axisX = Input.GetAxis("Horizontal");
        Vector2 vector = new Vector2(axisX, movementPlayer.rb.velocity.y);

        if (Input.GetKeyDown("w") || Input.GetKeyDown("space"))
        {
            Jump();
        }

        Move(vector);
    }

    void Move(Vector2 vector)
    {
        movementPlayer.MovePlayer(vector);
    }
    
    void Jump()
    {
        movementPlayer.JumpPlayer();
    }
}
