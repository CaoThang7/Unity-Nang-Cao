using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class serverlogin : MonoBehaviour
{
    [SerializeField] InputField username;
    [SerializeField] InputField password;



    [SerializeField] Button loginButton;


    [SerializeField] string url;

    WWWForm form;

    [System.Obsolete]
    public void OnLoginButtonClicked()
    {
        loginButton.interactable = false;
        StartCoroutine(Login());
    }

    [System.Obsolete]
    IEnumerator Login()
    {
        form = new WWWForm();

        form.AddField("username", username.text);
        form.AddField("password", password.text);

        WWW w = new WWW(url, form);

        yield return w;

        if (w.error != null)
        {
            print("error");
            Debug.Log("<color=red>" + w.text + "</color>");//error
        }
        else
        {
            if (w.isDone)
            {
                if (w.text.Contains("ERROR"))
                {
                    print("thất bại");

                    Debug.Log("<color=red>" + w.text + "</color>");//error
                }
                else
                {
                    print("success");
                    //open welcom panel
                    Debug.Log("<color=green>" + w.text + "</color>");//user exist
                    SceneManager.LoadScene(2);

                }
            }
        }

        loginButton.interactable = true;

        w.Dispose();
    }
}