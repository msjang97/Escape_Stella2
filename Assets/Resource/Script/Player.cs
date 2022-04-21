using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float movePower = 1f; //이동속도 변수
    public float jumpPower = 1f; //점프힘 변수
    public float MaxJump = 0; //최대 점프 횟수
    public int JumpCount = 0; //점프 몇번 했는지.

    private Rigidbody2D rigid; //플레이어 캐릭터 Rigidbody속성을 받아올 변수

    private Vector3 movement;

    private SpriteRenderer rend; // 그림반전을 위한 변수
    Animator animator; //애니메이션

    // Use this for initialization
    void Start()
    {     
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left; //
            animator.SetBool("walk", true); //애니메이션 재생
            rend.flipX = true;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
            animator.SetBool("walk", true); //애니메이션 재생
            rend.flipX = false;
        }

        else
        {
            animator.SetBool("walk", false);
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;

        
    }

    void Jump()
    {      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (JumpCount < MaxJump)
            {
                JumpCount++;         
                rigid.velocity = Vector2.up * jumpPower;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D collide)
    {
         if (collide.gameObject.tag == "Ground")
        {
            JumpCount = 0;       
        }
      
        if (collide.gameObject.tag == "Slime")
        {
            SceneManager.LoadScene("HardStage2");
        }
    }
}