using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player3D : MonoBehaviour
{
    //플레이어 캐릭터 변수
    private CharacterController PlayerCharater;
    private Vector3 MoveDirect;                // 캐릭터의 움직이는 방향.
    public float Speed = 6.0f;      // 캐릭터 스피드.
    public float JumpPower = 8.0f; // 캐릭터 점프 힘.
    public float Gravity = 20.0f;    //중력 값.

    //카메라 이동 변수
    public float MouseX = 0;
    public float MouseY = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        PlayerCharater = GetComponent<CharacterController>();
        MoveDirect = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraMoving();
        Restart();
        
    }

    void PlayerMove() //플레이어 이동 함수
    {
        if (PlayerCharater.isGrounded)
        {
            // 키보드 w,a,s,d 입력받아서 저장
            MoveDirect = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // 벡터 로컬 -> 월드 좌표로 변경
            MoveDirect = transform.TransformDirection(MoveDirect);

            // 스피드 증가.
            MoveDirect *= Speed;

            // 캐릭터 점프
            if (Input.GetButton("Jump"))
                MoveDirect.y = JumpPower;
        }

        // 캐릭터에 중력 적용
        MoveDirect.y -= Gravity * Time.deltaTime;

        // 캐릭터 이동
        PlayerCharater.Move(MoveDirect * Time.deltaTime);

        
    }

    void CameraMoving()
    {
        MouseX += Input.GetAxis("Mouse X") * 3; //마우스 좌우
        MouseY += Input.GetAxis("Mouse Y") * 3; //마우스 위아래
        MouseY = Mathf.Clamp(MouseY, -30.0f, 30.0f); // y축의 최솟값, 최댓값을 적용해서 마우스가 돌아가는 각도 제한

        transform.localEulerAngles = new Vector3(-MouseY, MouseX, 0); // 마이너스로 넣어야 위아래 움직임.
    }

    void Restart()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        else if (this.transform.position.y < -9.0f)
        {
            SceneManager.LoadScene("EasyStage");
        }
    }

}
