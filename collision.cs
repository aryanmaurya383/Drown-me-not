using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag=="enemy")
        {
            Restart();
        }
    }
    public void Restart()
    {
        //Destroys the gameobject
        Destroy(gameObject);
        
        //Restarts the level
        SceneManager.LoadScene(0);

    }
    
}
