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
        //anim = GetComponent<Animator>();
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
        if(Input.GetKey("w"))
        {
            rb.AddRelativeForce(Vector3.forward * 50);
            
        }

        if(Input.GetKey("d"))
        {
            rb.AddRelativeForce(Vector3.right *30);
        }

        if(Input.GetKey("a"))
        {
            rb.AddRelativeForce(Vector3.left *30);
        }

        if(Input.GetKey("s"))
        {
            rb.AddRelativeForce(Vector3.back *50);
        }
    }

    void DoJump()
    {
        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * 2000);
        }
    }
}
