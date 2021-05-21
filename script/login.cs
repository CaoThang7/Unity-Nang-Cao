//using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public InputField IDUSER;
    public InputField USERNAME;
    public InputField PASSWORD;
    public InputField LEVEL;
    public InputField POINT;



    string loginphp = "http://localhost/login/login.php";
    [System.Obsolete]
    public void themmoi()
    {
        StartCoroutine(connect());
    }
    [System.Obsolete]
    IEnumerator connect()
    {
        WWWForm wf = new WWWForm();
        wf.AddField("id_chuyen", IDUSER.text);
        wf.AddField("user_chuyen", USERNAME.text);
        wf.AddField("pass_chuyen", PASSWORD.text);
        wf.AddField("level_chuyen", LEVEL.text);
        wf.AddField("point_chuyen", POINT.text);
        //wf.AddField("password_chuyen", PASSWORD.text);
        WWW w = new WWW(loginphp, wf);
        yield return w;

        string tam = w.text;
        string tam1 = tam.TrimStart();
        string tam11 = tam1.TrimEnd();


        if (tam11 == "Thanh cong")
        {
         
            //print("dang nhap thanh cong");
            Application.LoadLevel("Login");
        }
        else
        {

            print("dang nhap khong thanh cong");
        }

    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//public class login : MonoBehaviour
//{
//    // Start is called before the first frame update
//    //public InputField IDUSER;
//    //public InputField USERNAME;
//    //public InputField PASSWORD;
//    //public InputField LEVEL;
//    //public InputField POINT;
//    public InputField IDUSER;
//    public InputField USERNAME;
//    public InputField PHONE;
//    public InputField ADDRESS;
//    public InputField GMAIL;
//    public InputField PASSWORD;


//    string loginphp = "http://localhost/login/login.php";


//    //public void themoi()
//    //{

//    //    StartCoroutine(connect());
//    //}

//    [System.Obsolete]
//    public void Themmoi()
//    {
//        StartCoroutine(connect());
//    }

//    [System.Obsolete]
//    IEnumerator connect()
//    {
//        WWWForm wf = new WWWForm();
//        wf.AddField("id_chuyen", IDUSER.text);
//        wf.AddField("user_chuyen", USERNAME.text);
//        wf.AddField("phone_chuyen", PHONE.text);
//        wf.AddField("address_chuyen", ADDRESS.text);
//        wf.AddField("gmail_chuyen", GMAIL.text);
//        wf.AddField("password_chuyen", PASSWORD.text);
//        WWW w = new WWW(loginphp, wf);
//        yield return w;

//        string tam = w.text;
//        string tam1 = tam.TrimStart();
//        string tam11 = tam1.TrimEnd();


//        if (tam11 == "thanh cong")
//        {
//            print("dang nhap thanh cong");
//        }
//        else
//        {

//            print("dang nhap khong thanh cong");
//        }

//    }
//}
