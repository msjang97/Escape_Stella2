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
    private SpriteRenderer rend; // 그림반전을 위한 변수
    Animator animator; //애니메이션

    public AudioClip WalkSound;
    public AudioClip JumpSound;
    public AudioClip DieSound;
    AudioSource PlayerAudioSource;

    public GameObject GameoverImage;



    void Start()
    {
        
        this.PlayerAudioSource = GetComponent<AudioSource>();
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        rend = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Bool_Jump", true);
            Jump();
        }
    }

    void FixedUpdate() //매 고정된 프레임율의 프레임마다 일정하게 호출해서 물리효과 사용하기에 좋음
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
        if (JumpCount < MaxJump)
        {
            PlaySound("JUMP");
            JumpCount++;
            rigid.velocity = Vector2.up * jumpPower;
        }
    }

    void OnCollisionEnter2D(Collision2D collide) //충돌처리
    {
        if (collide.gameObject.tag == "Ground") //땅과 충돌처리
        {
            JumpCount = 0;
            animator.SetBool("Bool_Jump", false);
        }

        if (collide.gameObject.tag == "Enemy") //몬스터와 충돌처리
        {
            PlaySound("DIE");
            animator.SetBool("Bool_Death", true);
            GameoverImage.SetActive(true);
            Invoke("TimetoScale", 1.0f);                 
        }
    }

    void PlaySound(string Act)
    {
        switch (Act) 
        {
            case "JUMP":
                PlayerAudioSource.clip = JumpSound;
                break;

            case "WALK":
                PlayerAudioSource.clip = WalkSound;
                break;

            case "DIE":
                PlayerAudioSource.clip = DieSound;
                break;
        }
        PlayerAudioSource.Play();
    }

    void TimetoScale()  //타임 스케일 조정
    {
        Time.timeScale = 0;    
    }


}