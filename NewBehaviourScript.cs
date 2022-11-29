using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour 
{
    public float maxSpeed;
    public float jumpPower;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    //1초에 60번
    //단발적인 입력은 Update
    {
        //Jump
        if(Input.GetButtonDown("Jump") && !anim.GetBool("isjumping")){
          rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
          anim.SetBool("isjumping", true);      
        }
        
        //Stop Speed
        if (Input.GetButtonDown("Horizontal")) {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }

        //Direction Sprite
        if(Input.GetButton("Horizontal"))
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        

        //Animation
        if (Mathf.Abs(rigid.velocity.x) < 0.3)
            anim.SetBool("isWalking", false);
        else 
            anim.SetBool("isWalking", true);
    }

    void FixedUpdate()
    //1초에 40번 
    {
        //Move Speed
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        //Max Speed
         if (rigid.velocity.x > maxSpeed)// Right Max Speed
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1))// Left Max Speed
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);

        //Lamding platform
        if(rigid.velocity.y < 0) {
        Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("platfrom"));

        if(rayHit.collider != null) {
            if(rayHit.distance < 0.5f)
            anim.SetBool("isjumping", false);
        }
        

        }
    }


}

