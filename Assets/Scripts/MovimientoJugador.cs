using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float runSpeed = 80;
    public float jumpSpeed = 6.5f;
    float horizontal;

    Rigidbody2D rb2D;
    Animator m_Animator;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
    }

     void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        if(horizontal != 0.0f)
        {
            rb2D.velocity = new Vector2(runSpeed* horizontal * Time.deltaTime, rb2D.velocity.y);
            transform.rotation = horizontal >= 0 ? Quaternion.Euler(0,0,0) :  Quaternion.Euler(0,-180f,0);
            m_Animator.SetBool("Movimiento", true);
            m_Animator.ResetTrigger("Salto");
            
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            m_Animator.SetBool("Movimiento", false);
        }

        
        
        
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
            //transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
            m_Animator.SetBool("Movimiento", false);
            m_Animator.SetTrigger("Salto");
        }
    
    }
}


/* Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
 transform.rotation = Quaternion.LookRotation(movement);
  
  
 transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);
*/