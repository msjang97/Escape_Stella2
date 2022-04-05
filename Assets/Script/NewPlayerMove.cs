using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPlayerMove : MonoBehaviour
{

    public float movePower = 1f; //�̵��ӵ� ����
    public float jumpPower = 1f; //������ ����
    public float MaxJump = 0; //�ִ� ���� Ƚ��
    public int JumpCount = 0; //���� ��� �ߴ���.

    private Rigidbody2D rigid; //�÷��̾� ĳ���� Rigidbody�Ӽ��� �޾ƿ� ����

    private Vector3 movement;

    private SpriteRenderer rend; // �׸������� ���� ����
    Animator animator; //�ִϸ��̼�

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
            moveVelocity = -Vector3.left; //
            animator.SetBool("walk", true); //�ִϸ��̼� ���
            rend.flipX = false;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = -Vector3.right;
            animator.SetBool("walk", true); //�ִϸ��̼� ���
            rend.flipX = true;
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
    }
}
