using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HelpSceneMenuButton : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }

    public void Home()
    {
        SceneManager.LoadScene("HomeScene");
        Time.timeScale = 1f;
        Cursor.visible = true;

    }
}
