using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    private PlayerMove thePlayer;
    public float moveSpeed = 3;
    public bool facingRight = true;
    public AudioSource screech;

    public float playerRange;

    public bool playOnce = false;

    void Start() {
        thePlayer = FindObjectOfType<PlayerMove>();
    }

    void Update() {

        transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, moveSpeed * Time.deltaTime);


        if ((thePlayer.transform.position.x - transform.position.x < 2 || thePlayer.transform.position.x - transform.position.x < 2) && playOnce == false) {
            screech.Play();
            playOnce = true;
        } else if (thePlayer.transform.position.x - transform.position.x > 2 || thePlayer.transform.position.x - transform.position.x > 2) {
            playOnce = false;
        }

        if (thePlayer.transform.position.x - transform.position.x < 0.0f && facingRight == false) {
            flip();
        } else if (thePlayer.transform.position.x - transform.position.x > 0.0f && facingRight == true) {
            flip();
        }
    }

    void flip() {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
