using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createoj : MonoBehaviour
{
    public GameObject doituong;
    public GameObject vitri;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(connect());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator connect()
    {
        //Khoang thoi gian cho de tao ra 1 Object
        yield return new WaitForSeconds(4);
        //Lay vi tri de bat dau tao ra 1 Object
        Vector3 temp = vitri.transform.position;
        temp.y = Random.Range(-5f, 5f);
        Instantiate(doituong, temp, Quaternion.identity);
        StartCoroutine(connect());


    }
}
