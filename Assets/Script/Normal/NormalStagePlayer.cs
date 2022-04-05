using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NormalStagePlayer : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        chararacterMove();
        endPointTrriger();

    }

    public void chararacterMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Player.transform.position = new Vector2(transform.position.x, transform.position.y + 0.9f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Player.transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Player.transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Player.transform.position = new Vector2(transform.position.x, transform.position.y - 0.9f);
        }
    }

    public void endPointTrriger()
    {
        if (this.transform.position.x < -1.75f && this.transform.position.x > -2.75f)
        {
            if (this.transform.position.y < 6.0f && this.transform.position.y > 5.15f)
                SceneManager.LoadScene("Title");
        }
    }

    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.name == "EndPoint1")
        {
            Debug.Log("¥Í¿Ω");
            SceneManager.LoadScene("Title");
        }

    }
}
