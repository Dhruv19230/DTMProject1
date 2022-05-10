using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   //VAriables
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Players horizontal movement
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        //Code for spacebar(jumpbutton)
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            //Code for the jump force
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("Jump");
        }


    }

    //Ground check
    private void OnCollisionEnter2D(Collision2D other)
    {
        //when player hits ground then they are not jumping
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

    }
    private void OnCollisionExit2D(Collision2D other)
    {
        //when plyer not touching ground they are jumping
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}