using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed = 4;
    public bool facingRight = false;
    private int playerJumpPower = 800;
    private float moveX;
    public bool isGrounded;
    public string midjump = "n";

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move() {
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded && (midjump == "n") ) {
            jump();
            midjump = "y";
        }

        if (GetComponent<Rigidbody2D>().velocity.y == 0) {
            midjump = "n";
        }

        //direction
        if (moveX < 0.0f && facingRight == false) {
            flip();
        } else if (moveX > 0.0f && facingRight == true) {
            flip();
        }

        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void jump() {
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
        isGrounded = false;
    }

    void flip() {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject.tag == "ground") {
            isGrounded = true;
        }
    }
}
