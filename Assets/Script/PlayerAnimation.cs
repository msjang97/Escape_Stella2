using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAnimation : MonoBehaviour
{
    public float movePower = 1f;
    public float jumpPower = 1f;
    public float MaxJump = 0;
    public int JumpCount = 0;

    private Rigidbody2D rigid;

    private Vector3 movement;


    // Use this for initialization
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
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
            moveVelocity = Vector3.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
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