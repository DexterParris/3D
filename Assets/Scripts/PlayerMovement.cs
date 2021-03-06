using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        DoMove();
        DoJump();
    }

    void DoMove()
    {
        anim.SetBool("Moving", false);
        anim.SetBool("MovingB", false);

        if (Input.GetKey("w"))
        {
            anim.SetBool("Moving", true);
            rb.AddRelativeForce(Vector3.forward * 40);
        }

        if(Input.GetKey("d") && anim.GetBool("Jumping") == false)
        {
            rb.AddTorque(transform.up * 50);
        }

        if(Input.GetKey("a") && anim.GetBool("Jumping") == false )
        {
            rb.AddTorque(transform.up * -50);
        }

        if(Input.GetKey("s"))
        {
            anim.SetBool("MovingB", true);
            rb.AddRelativeForce(Vector3.back * 40);
        }
    }

    void DoJump()
    {

        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("Jumping", true);
            rb.AddForce(Vector3.up * 1000);
        }
        else
        {
            anim.SetBool("Jumping", false);
        }
    }
}
