using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerGame : MonoBehaviour
{
    private Animator player;
    public float speed = 5f;
    public float jump = 5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    player.SetBool("isRun", true);
        //    player.SetBool("isStop", false);

        //    gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

        //}

        //di chuyen mui ten phai
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.SetBool("isRun", true);//doi trang thai
            player.SetBool("isStop", false);
            //di chuyen
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            //quay dau
            if (gameObject.transform.localScale.x < 0)
            {
                gameObject.transform.localScale =
                    new Vector3(gameObject.transform.localScale.x * -1,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z);
            }
        }
        // di chuyen mui ten trai
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.SetBool("isRun", true);
            player.SetBool("isStop", false);
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            //quay dau
            if (gameObject.transform.localScale.x > 0)
            {
                gameObject.transform.localScale =
                    new Vector3(gameObject.transform.localScale.x * -1,
                    gameObject.transform.localScale.y,
                    gameObject.transform.localScale.z);
            }
        }
        //Nhay cao
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            player.SetBool("isRun", true);
            player.SetBool("isStop", false);
            gameObject.GetComponent<Rigidbody2D>().velocity =
                new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, jump);
        }
    }
}

