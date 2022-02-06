using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //インスペクターで設定する
    //移動速度
    public float speed;
    //ジャンプ速度
    public float jumpVelocity;
    //ジャンプ速度の減衰
    public float dump;
    public GroundCheck ground;
    

    private Animator anim = null;
    private Rigidbody2D rb = null;
    private bool isGround = false;
    private bool isEnter = false;
    
   


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGround = ground.IsGround();
        

        float horizontalKey = Input.GetAxis("Horizontal");
        float jumpKey = Input.GetAxis("Jump");
        float xSpeed = 0.0f;
        if (horizontalKey > 0)
        {
            transform.localScale = new Vector3(6, 6, 1);
            anim.SetBool("run", true);
            xSpeed = speed;
        }
        else if (horizontalKey < 0)
        {
            transform.localScale = new Vector3(-6, 6, 1);
            anim.SetBool("run", true);
            xSpeed = -speed;
        }
        else
        {
            anim.SetBool("run", false);
            xSpeed = 0.0f;
        }
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);

        if (jumpKey > 0 && isGround == true)
        {
            anim.SetBool("jump", true);
            this.rb.velocity = new Vector2(0, this.jumpVelocity);
        }

        if (jumpKey == 0)
        {
            if (this.rb.velocity.y > 0)
            {
                this.rb.velocity *= this.dump;
            }
        }
        if (rb.velocity.y < 0 && isGround == false)
        {
            anim.SetBool("down", true);
            anim.SetBool("jump", false);
        }
        else
        {
            anim.SetBool("down", false);
        }

        if (isGround == true)
        {
            anim.SetBool("down", false);
        }
        if (isGround == true && isEnter == true)
        {
            anim.SetBool("jump", false);
            isEnter = false;
        }
        if (isGround == false)
        {
            isEnter = true;
            anim.SetBool("run", false);
        }
    }
   
}
