using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("MainGameScene");
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void Help()
    {
        SceneManager.LoadScene("HelpScene");
        Cursor.visible = true;

    }
    public void Exit()
    {
        Debug.Log("Exiting");
        Application.Quit();
        Cursor.visible = true;
    }
}
