using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //va cham vat ngau nhien
        if (collision.gameObject.tag == "wall")
        {
            Destroy(GameObject.Find("user"));
            //Debug.Log("You loose");
            Application.LoadLevel("gameover");

        }
        //va cham dinh
        if (collision.gameObject.tag == "dinh")
        {
            Destroy(GameObject.Find("user"));
            //Debug.Log("You loose");
            Application.LoadLevel("gameover");

        }

        if (collision.gameObject.tag == "dinh")
        {
            Destroy(GameObject.Find("wall"));
            //Debug.Log("You loose");
        }

    }
}
