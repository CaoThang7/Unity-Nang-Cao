using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Obsolete]
    public void GoToLevel()
    {
        Application.LoadLevel("shopscreen");
    }

    [System.Obsolete]
    public void GoToBXH()
    {
        Application.LoadLevel("DanhSach");
    }
}
