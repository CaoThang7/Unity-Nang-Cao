using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listuser : MonoBehaviour
{
    public GameObject rownew;
    string URL = "http://localhost/danhsach/danhsach.php";

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        getdata();
    }

    [System.Obsolete]
    public void getdata()
    {
        StartCoroutine(connect());
    }

    [System.Obsolete]
    IEnumerator connect()
    {
        WWWForm wf = new WWWForm();
        WWW w = new WWW(URL, wf);
        yield return w;
        string data = w.text;
        // data = ID01-TEO-123AVC-1-2-,id02-ty-abc123-5-1-,id03-ty-abc123-5-1-,ID04-LT- 1234ACX-0-0-,

        // khai bao mang de luu tru
        string[] a = new string[] { };
        a = data.Split(',');
        // mang a co 4 phan tu
        for (int i = 0; i < (a.Length) - 1; i++)
        {

            string dong = a[i];

            string[] b = new string[] { };
            b = dong.Split('-');
            // mang b co 5 phan tu
            GameObject g = (GameObject)Instantiate(rownew);
            g.transform.SetParent(this.transform);
            //g.transform.Find("ID_USER").GetComponent<Text>().text = "1";
            //g.transform.Find("USERNAME").GetComponent<Text>().text = "2";
            //g.transform.Find("PHONE").GetComponent<Text>().text = "3";
            //g.transform.Find("ADDRESS").GetComponent<Text>().text = "4";
            //g.transform.Find("GMAIL").GetComponent<Text>().text = "5";
            //g.transform.Find("PASSWORD").GetComponent<Text>().text = "6";

            g.transform.Find("ID_USER").GetComponent<Text>().text = b[0];
            g.transform.Find("USERNAME").GetComponent<Text>().text = b[1];
            g.transform.Find("PASSWORD").GetComponent<Text>().text = b[2];
            g.transform.Find("LEVEL").GetComponent<Text>().text = b[3];
            g.transform.Find("POINT").GetComponent<Text>().text = b[4];

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
