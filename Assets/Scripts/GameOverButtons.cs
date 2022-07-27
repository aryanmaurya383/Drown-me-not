using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainGameScene");
        Time.timeScale = 1f;
        Cursor.visible = false;
    } 
    public void Home()
    {
        SceneManager.LoadScene("HomeScene");
        Time.timeScale = 1f;
        Cursor.visible = true;
    }

}
