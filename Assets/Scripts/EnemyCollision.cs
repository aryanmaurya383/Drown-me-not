using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DiverRepulsion.Restart();
        }
        if (collision.gameObject.CompareTag("Stone"))
        {
            Destroy(this.gameObject);
        }
    }
}
