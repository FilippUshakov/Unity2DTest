using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator anim;
    Vector2 movement;
    string state = "PlayerIdle";

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.deltaTime);

        if (movement.x == 0 && movement.y == 0)
        {
            ChangeState("PlayerIdle");
        }
        if (movement.y == 1)
        {
            ChangeState("PlayerWalkUp");
        }
        else if (movement.y == -1)
        {
            ChangeState("PlayerWalkDown");

        }
        if (movement.x == 1)
        {
            ChangeState("PlayerWalkRight");
        }
        else if (movement.x == -1)
        {
            ChangeState("PlayerWalkLeft");
        }
        anim.Play(state);
        if (movement.y != 0 && movement.x != 0)
        {
            movementSpeed = speed / Mathf.Sqrt(2f);

        }
        else {
            movementSpeed = speed;
        }
    }
    void ChangeState(string NewState) {
        if (NewState == state) return;
        //if(state == "PlayerIdle" || NewState == "PlayerIdle") { }
        //if (NewState != "PlayerIdle" && state != "PlayerIdle") return;
        state = NewState;
    }
}
