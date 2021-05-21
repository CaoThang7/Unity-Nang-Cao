using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighttwo : MonoBehaviour
{
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dinh")
        {
            Destroy(GameObject.Find("user"));
        }

    }
}
