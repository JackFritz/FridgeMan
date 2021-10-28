using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://youtu.be/4HpC--2iowE
//help from brackeys tutorial

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;
    public bool facingRight;

    public float speed = 6f;
    public float horizontal;
    public float vertical;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;


        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
        
       
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        //animator.SetFloat("Speed", Mathf.Abs(vertical));


        //flips the sprite
        if ((horizontal < 0 && facingRight) || (horizontal > 0 && !facingRight))
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
            
        }    
    }
}
