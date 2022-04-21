using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player3D : MonoBehaviour
{
    //�÷��̾� ĳ���� ����
    private CharacterController PlayerCharater;
    private Vector3 MoveDirect;                // ĳ������ �����̴� ����.
    public float Speed = 6.0f;      // ĳ���� ���ǵ�.
    public float JumpPower = 8.0f; // ĳ���� ���� ��.
    public float Gravity = 20.0f;    //�߷� ��.

    //ī�޶� �̵� ����
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

    void PlayerMove() //�÷��̾� �̵� �Լ�
    {
        if (PlayerCharater.isGrounded)
        {
            // Ű���� w,a,s,d �Է¹޾Ƽ� ����
            MoveDirect = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // ���� ���� -> ���� ��ǥ�� ����
            MoveDirect = transform.TransformDirection(MoveDirect);

            // ���ǵ� ����.
            MoveDirect *= Speed;

            // ĳ���� ����
            if (Input.GetButton("Jump"))
                MoveDirect.y = JumpPower;
        }

        // ĳ���Ϳ� �߷� ����
        MoveDirect.y -= Gravity * Time.deltaTime;

        // ĳ���� �̵�
        PlayerCharater.Move(MoveDirect * Time.deltaTime);

        
    }

    void CameraMoving()
    {
        MouseX += Input.GetAxis("Mouse X") * 3; //���콺 �¿�
        MouseY += Input.GetAxis("Mouse Y") * 3; //���콺 ���Ʒ�
        MouseY = Mathf.Clamp(MouseY, -30.0f, 30.0f); // y���� �ּڰ�, �ִ��� �����ؼ� ���콺�� ���ư��� ���� ����

        transform.localEulerAngles = new Vector3(-MouseY, MouseX, 0); // ���̳ʽ��� �־�� ���Ʒ� ������.
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
