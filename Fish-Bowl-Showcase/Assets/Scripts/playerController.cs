using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class playerController : MonoBehaviour
{

    public Animator anim;
    private Rigidbody rb;
    public LayerMask layerMask;

    public bool grounded;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    private void FixedUpdate()
    {
        Grounded();
        Jump();
        Move();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Jump()
    {
          if (Input.GetKeyDown(KeyCode.Space) && this.grounded)
        {
            this.rb.AddForce(Vector3.up * 6, ForceMode.Impulse);
          //  anim.SetBool("jump", true);
        }
       
       // this.anim.SetBool("jump", false);

    }

    private void Grounded()
    {
        if(Physics.CheckSphere(this.transform.position + Vector3.down, 1.6f, layerMask))
        {
            this.grounded = true;
        }
        else
        {
            this.grounded = false;

        }
        this.anim.SetBool("jump", !this.grounded);



    }

    private void Move()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");
        anim.SetFloat("vertical", verticalAxis);
        anim.SetFloat("horizontal", horizontalAxis);

        Vector3 movement = this.transform.forward * verticalAxis + this.transform.right * horizontalAxis;

        movement.Normalize();

        this.transform.position += movement * 0.04f;

        this.anim.SetFloat("vertical", verticalAxis);
        this.anim.SetFloat("horizontal", horizontalAxis);
    }



}
